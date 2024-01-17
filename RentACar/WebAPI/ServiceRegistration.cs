using AutoMapper;
using Business.Abstract;
using Business.BrandBusinessRules;
using Business.Concrete;
using Business.Request.Brand;
using Business.Response.Brand;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Conrete;

namespace WebAPI;

public static class ServiceRegistration
{
    public static readonly IBrandDal BrandDal = new InMemoryBrandDal();
    public static readonly BrandBusinessRules brandBusinessRules= new BrandBusinessRules(BrandDal);
    public static IMapper Mapper = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<AddBrandRequest, Brand>();
        cfg.CreateMap<Brand, AddBrandResponse>();
    }).CreateMapper();

    public static readonly IBrandService BrandService = new BrandManager(
        BrandDal,
        BrandBusinessRules,
        Mapper
    );
    //Ioc yapımızı kurdugumuz Dependcy Injection ile daha verimli hale getirecegiz.

}
