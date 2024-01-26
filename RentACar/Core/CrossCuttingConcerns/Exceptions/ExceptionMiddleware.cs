using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mime;

namespace Core.CrossCuttingConcerns.Exceptions;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        // Delegate: Bir kod bütününü temsil eder.
        // RequestDelegate: Bir HTTP Request akışındaki bir sonraki adımı temsil eder.
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        // HttpContext:Bir Http Request  akısını temsil eder.
        // Asynchronous Programlama: Eş zamanlı programlama
        //async:Bir metodu es zamanlı  hale getirir.await kullanılacaksa eklenmesi gerekir.
        // Task: Bir asenkron işlemi temsil eder.

        try
        {
            //AddBrandResponse response = _brandService.Add(request);
            //return response;//200 OK
            //Örnek olarak endpoint metodundaki kodların referansı _next'tedir.

            await _next(httpContext);
            //await: Bir sonraki adımın tamamlamasını bekler.
        }
        catch (Exception exception)
        {
            await handleExceptionAsync(httpContext, exception);
        }
    }

    private Task handleExceptionAsync(HttpContext httpContext, Exception exception)
    {
        httpContext.Response.ContentType = MediaTypeNames.Application.Json;

        //if(exception.GetType () == typeof(BusinessException)) 
        //{ 
        //    BusinessException businessException = (BusinessException)exception;//casting
        //    return createBusinessProblemDetailsResponse (httpContext, businessException);
        //}

        if (exception is BusinessException businessException)
            return createBusinessProblemDetailsResponse(httpContext, businessException);


        return createInternalProblemDetailsResponse(httpContext, exception);
    }


    private Task createBusinessProblemDetailsResponse(HttpContext httpContext, BusinessException exception)
    {
        httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        BusinessProblemDetails businessProblemDetails = new()
        {
            Title = "Business Exception",
            Type = "https://doc.rentacar.com/business",
            Status = StatusCodes.Status400BadRequest,
            Detail = exception.Message,
            Instance = httpContext.Request.Path
        };
        return httpContext.Response.WriteAsync(businessProblemDetails.ToString());
    }
    private Task createInternalProblemDetailsResponse(HttpContext httpContext, Exception exception)
    {
        httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        ProblemDetails problemDetails =
            new()
            {
                Title = "Internal Server Error",
                Type = "https://doc.rentacar.com/internal",
                Status = StatusCodes.Status500InternalServerError,
                Detail = exception.Message,
                Instance = httpContext.Request.Path
            };

        return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(problemDetails));
    }
}
