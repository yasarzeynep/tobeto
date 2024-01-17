using Business.Request.Brand;
using Business.Response.Brand;
using Entities.Conrete;

namespace Business.Abstract;

public interface IBrandService
{
    public AddBrandResponse Add(AddBrandRequest request);
    public IList<Brand> GetList(); //Brand Listesi donuyor
}
