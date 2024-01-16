﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Conrete;
using Microsoft.AspNetCore.Mvc;
using WebAP;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController()
        {
            //Her Http Request ıcın yeni  bir controoller olusturur
            _brandService = ServiceRegistration.BrandService;
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
        public ICollection<Brand> GetList()
        {
            IList<Brand> brandList = _brandService.GetList(); 
            return brandList;
        }

        //[HttpPost("/add")] //Veri göndermek //http://localhost:5191/api/brands/add
        [HttpPost] //Veri göndermek //http://localhost:5191/api/brands
        public Brand Add()
        {
            Brand addedBrand=_brandService.Add(addBrandRequest);
            return adddedBrand;
        }
    }
}