using Business.Dtos.Brand;

namespace Business.Response.Brand
{
    public class GetBrandListResponse
    {
        public ICollection<BrandListItemDto>Items { get; set; }

        public GetBrandListResponse()
        {

            Items = Array.Empty<BrandListItemDto>();
        }
        public GetBrandListResponse(ICollection<BrandListItemDto> items)
        {
            Items = items;
        }
    }
}