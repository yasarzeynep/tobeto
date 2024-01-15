using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Conrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryBrandDal : InMemoryEntityRepositoryBase<Brand, int>, IBrandDal
{
    //public IList<Brand> GetBtrandsByNameSearch(string nameSearch)
    //{
    //    throw new NotImplementedException();
    //}
}
