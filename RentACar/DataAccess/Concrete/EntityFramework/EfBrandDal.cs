using DataAccess.Abstract;
using Entities.Conrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfBrandDal : IBrandDal
{
    public void Add(Brand entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Brand entity)
    {
        throw new NotImplementedException();
    }

    public Brand? Get(Func<Brand, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IList<Brand> GetList(Func<Brand, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public void Update(Brand entity)
    {
        throw new NotImplementedException();
    }
}
