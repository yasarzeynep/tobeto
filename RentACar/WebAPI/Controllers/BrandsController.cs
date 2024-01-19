using Business.Abstract;
using Business.Concrete;
using Business.Request.Brand;
using Business.Response.Brand;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Conrete;
using Microsoft.AspNetCore.Mvc;
using WebAPI;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            //Her Http Request ıcın yeni  bir controller olusturur
            _brandService = brandService;
            //Daha sonra Ioc Container yapımızı kurdugumuz Dependency Injection ile daha verimli  hale getirecegiz.

        }
        //[HttpGet]

        //public ActionResult<string> //IActionResult 
        //    GetList()
        //{
        //    return Ok("BrandsController");
        //}

        //200 dönmesi icin;
        //[HttpGet]
        //public string GetList()
        //     { 
        //    return "BrandsController";
        //    }

        [HttpGet]
        public GetBrandListResponse GetList([FromQuery] GetBrandListRequest request) // Referans tipleri varsayılan olarak request body'den alır.
        {
            GetBrandListResponse response = _brandService.GetList(request);
            return response;
        }

        //[HttpPost("/add")] //Veri göndermek //http://localhost:5191/api/brands/add
        [HttpPost] //Veri göndermek //http://localhost:5191/api/brands
        public ActionResult <AddBrandResponse> Add(AddBrandRequest request)
        {
            AddBrandResponse response=_brandService.Add(request);
            //return response;//200 OK
            return CreatedAtAction(nameof(GetList), response);//201 Created
        }
    }
}
