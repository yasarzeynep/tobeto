using Core.DataAccess;
using Entities.Concrete;
using Entities.Conrete;

namespace DataAccess.Abstract;

public interface IBrandDal : IEntityRepository<Brand, int>
{
    //CRUD - Create, Read, Update, Delete

    //Canlandırma

    //public IList<Brand> GetBtrandsByNameSearch(string nameSearch);

}
