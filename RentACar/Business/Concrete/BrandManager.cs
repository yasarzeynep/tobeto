using AutoMapper;
using Business.Abstract;
using Business.Request.Brand;
using Business.Response.Brand;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Conrete;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
   private IBrandDal _brandDal;
    private readonly BrandBusinessRules _brandBusinessRules;
    private readonly IMapper _mapper;
    public BrandManager (IBrandDal brandDal) //Somut 
    {
        //new InMemoryBrandDal(); // Başka katmanların class'ları new'lenmez.
        //Bu yüzden dependency injection kullanıyoruz.
        _brandDal = brandDal;
        _mapper = mapper;
    }

    public AddBrandResponse Add(AddBrandRequest request)
    {
        _brandBusinessRules.CheckIfBrandNameNotExits(request.Name); //İs Kuralları
    //İs Kuralları
    //Validation
    //Yetki Kontrolü
    //Cache
    //Transaction
   
    //Brand addedBrand=
    //Brand brandToAdd = new(request.Name)
        Brand addToBrand=_mapper.Map<Brand> (request);//Mapping
       _brandDal.Add(brandToAdd);
        AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
        return response;
    }

    public GetBrandListResponse GetList(GetBrandListResponse request)
    {
        //İs Kuralları
        //Validation
        //Yetki Kontrolü
        //Cache
        //Transaction

        IList<Brand>brandList=_brandDal.GetList();
        return brandList;
    }
}
