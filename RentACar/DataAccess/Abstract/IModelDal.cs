using Core.DataAccess;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace DataAccess.Abstract;

    public interface IModelDal : IEntityRepository<Model, int>

    {


    }
    
