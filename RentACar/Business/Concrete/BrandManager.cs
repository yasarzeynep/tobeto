using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Conrete;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
   private IBrandDal _brandDal;

    public BrandManager (IBrandDal brandDal) //Somut 
    {
        //new InMemoryBrandDal(); // Başka katmanların class'ları new'lenmez.
        //Bu yüzden dependency injection kullanıyoruz.
        _brandDal = brandDal;
    }

    public Brand Add(Brand brand)
    {
    //İs Kuralları
    //Validation
    //Yetki  kONTROLÜ
    //Cache
    //Transaction
   
    //Brand addedBrand=
        _brandDal.Add(brand);
    return brand;
    }

    public IList<Brand> GetList()
    {
        //İs Kuralları
        //Validation
        //Yetki  kONTROLÜ
        //Cache
        //Transaction

        IList<Brand>brandList=_brandDal.GetList();
        return brandList;
    }
}
