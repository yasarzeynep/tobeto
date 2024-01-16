using Core.DataAccess;
using Entities.Conrete;
namespace DataAccess.Abstract;
public interface IBrandDal : IEntityRepository<Brand, int>
{
    //CRUD - Create, Read, Update, Delete

    //Canlandırma;
    //IEntityRepository<TEntity=Brand, TEntityId=int> canlandırma
    //public void Add(TEntity entity);
    //public void Update(TEntity entity);
    //public void Delete(TEntity entity);
    //public IList<Brand> GetList();
    //public TEntity? GetById(TEntityId id);

    //public IList<Brand> GetBtrandsByNameSearch(string nameSearch);

}
