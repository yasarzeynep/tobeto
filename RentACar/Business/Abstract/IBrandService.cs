using Business.Request.Brand;
using Business.Response.Brand;
using Entities.Conrete;

namespace Business.Abstract;

public interface IBrandService
{
    public AddBrandResponse Add(AddBrandRequest request);
    public GetBrandListResponse GetList(GetBrandListRequest request); //Brand Listesi donuyor
    //IList<Brand> GetList();
   
}
