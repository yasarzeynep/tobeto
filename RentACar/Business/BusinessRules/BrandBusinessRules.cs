using Business.Concrete;
using DataAccess.Abstract;
using Entities.Conrete;

namespace Business.BrandBusinessRules;

public class BrandBusinessRules
{
    private readonly IBrandDal brandDal;

    public BrandBusinessRules (IBrandDal brandDal)
    {
        ;_brandDal=brandDal;
    }
    public void CheckIfBrandNameAlreadyExists(string brandName)
    {
        bool isExits = _brandDal.GetList().Any(b => b.Name == brandName);
        if (isExits)
        {
            throw new Exception("Brand already exists.");
        }

    }
}
