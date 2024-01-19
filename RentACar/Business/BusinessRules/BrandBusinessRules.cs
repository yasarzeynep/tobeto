
using DataAccess.Abstract;

namespace Business.BusinessRules;

public class BrandBusinessRules
{
    private readonly IBrandDal _brandDal;
    

    public BrandBusinessRules (IBrandDal brandDal)
    {
        _brandDal=brandDal;
    }
    public void CheckIfBrandNameNotExists(string brandName)
    {
        bool isExits = _brandDal.GetList().Any(b => b.Name == brandName);
        if (isExits)
        {
            throw new Exception("Brand already exists.");
        }

    }

    internal void CheckIfBrandNameNotExits(string name)
    {
        throw new NotImplementedException();
    }
}
