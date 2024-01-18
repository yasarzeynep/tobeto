using Business.Request.Brand;
using Business.Response.Brand;
using Entities.Conrete;

namespace Business.Abstract;

public interface IBrandService
{
    public AddBrandResponse Add(AddBrandRequest request);
    public GetBrandListResponse GetList(GetBrandListResponse request); //Brand Listesi donuyor
}
