﻿using Core.DataAccess;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace DataAccess.Abstract;

    public interface IModelDal : IEntityRepository<Model, int>
    {
    // IEntityRepository<TEntity=Model, TEntityId=int> kalıtımının örnek canlandırması:
    //public IList<Model> GetList();
    //public Model? GetById(int id);
    //public void Add(Model entity);
    //public void Update(Model entity);
    //public void Delete(Model entity);
}
