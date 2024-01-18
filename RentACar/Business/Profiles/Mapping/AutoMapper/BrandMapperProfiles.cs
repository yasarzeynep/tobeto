using AutoMapper;
using Business.Request.Brand;
using Entities.Conrete;

namespace Business.Profiles.Mapping.AutoMapper;

public class BrandMapperProfiles:Profile //Profile AutoMapperden geliyor.
{
    public BrandMapperProfiles()
    {
        CreateMap<AddBrandRequest, Brand>();
        CreateMap<Brand, AddBrandRequest>();
    }
    
}
