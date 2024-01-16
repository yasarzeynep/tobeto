using Entities.Conrete;

namespace Business.Abstract;

public interface IBrandService
{
    public Brand Add(Brand brand);
    public IList<Brand> GetList(); //Brand Listesi donuyor
}
