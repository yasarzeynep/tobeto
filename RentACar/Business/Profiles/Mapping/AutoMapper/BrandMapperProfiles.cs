using AutoMapper;
using Business.Dtos.Brand;
using Business.Request.Brand;
using Business.Response.Brand;
using Entities.Conrete;
using System.Diagnostics.Metrics;

namespace Business.Profiles.Mapping.AutoMapper;

public class BrandMapperProfiles:Profile //Profile AutoMapperden geliyor.
{
    public BrandMapperProfiles()
    {
        CreateMap<AddBrandRequest, Brand>();
        CreateMap<Brand, AddBrandRequest>();
    
    CreateMap<Brand, BrandListItemDto>();
        CreateMap<IList<Brand>, GetBrandListResponse>()
            .ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
    }
}
