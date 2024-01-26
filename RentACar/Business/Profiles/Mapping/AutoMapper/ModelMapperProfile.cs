using AutoMapper;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class ModelMapperProfile:Profile
    {
        public ModelMapperProfile()
        {
            CreateMap<AddModelRequest, Model>();
            CreateMap<Model, ModelListItemDto>();
            CreateMap<IList<Model>, GetModelListResponse>()
                .ForMember(dest=>dest.Items, opt=>opt.MapFrom(src=>src));
        }
    }
}
