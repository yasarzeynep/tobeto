
using Core.Entities;
using Entities.Conrete;
using System.IO.Pipes;

namespace Entities.Concrete;
public class Model:Entity<int>
{
    public int BrandId{ get; set; } //normalizasyon; ornek:BMW marka arabasının bir Id si var
    public int FuelId { get; set; }
    public int TransmissionId {  get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string Year { get; set; }

    //lazy  loading 
    public Brand? Brand { get; set; } = null; //one-to-one iliskisi var
    public Fuel? Fuel { get; set; } = null; //one-to-one iliskisi var
    public Transmission? Transmission { get; set; } = null; //one-to-one iliskisi var

    public ICollection<Car>? Cars { get; set; } = null; //model ile car arasında one-to-mant iliskisi var
    public Model(int brandId, int fuelId, int transmissionId, string name, decimal dailyPrice, string year)
    {
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        DailyPrice = dailyPrice;
        Year = year;
    }
    public Model()
    {
        
    }

}
