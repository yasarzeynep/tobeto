using Business;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelsController : ControllerBase
{
    private readonly IModelService _modelService;

    public ModelsController(IModelService modelService)
    {
        _modelService = modelService;
    }

    [HttpGet]
    public GetModelListResponse GetList([FromQuery] GetModelListRequest request)
    {
        GetModelListResponse response = _modelService.GetList(request);
        return response;
    }

    [HttpGet("{Id}")]

    public GetModelByIdResponse GetById([FromQuery] GetModelByIdRequest request)
    {
        GetModelByIdResponse response = _modelService.GetById(request);
        return response;
    }
    [HttpPost]
    public ActionResult<AddModelResponse> Add(AddModelRequest request)
    {
        AddModelResponse response = _modelService.Add(request);
        return CreatedAtAction(
            actionName: nameof(GetById),
            routeValues: new { Id = response.Id }, //Anonymous object  
            value: response
            );
    }

    [HttpPut("{Id}")]
    public ActionResult<UpdateModelResponse> Update([FromQuery] int Id, [FromBody] UpdateModelRequest request)
     {
        if (Id != request.Id)
            return BadRequest();

    UpdateModelResponse response = _modelService.Update(request);
        return Ok(response);
       }

     [HttpDelete("{Id}")] 
      public DeleteModelResponse Delete([FromRoute] DeleteModelRequest request)
      {
       DeleteModelResponse response = _modelService.Delete(request);
       return response;
       }


  }  



