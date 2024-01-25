
using Core.CrossCuttingConcerns.Exceptions;
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
        bool isExits = _brandDal.Get(brand => brand.Name == brandName) is not null;
        if (isExits)
        {
            throw new BusinessException("Brand already exists.");
        }

    }

}
