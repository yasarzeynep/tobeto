﻿using DataAccess.Abstract;
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

    public IList<Brand> GetBtrandsByNameSearch(string nameSearch)
    {
        throw new NotImplementedException();
    }

    public Brand? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IList<Brand> GetList()
    {
        throw new NotImplementedException();
    }

    public void Update(Brand entity)
    {
        throw new NotImplementedException();
    }
}
