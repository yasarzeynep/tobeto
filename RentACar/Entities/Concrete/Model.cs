
using Core.Entities;
using Entities.Conrete;

namespace Entities.Concrete;
public class Model:Entity<int>
{
    public int BrandId{ get; set; }
    public string Name { get; set; }
    public string Year { get; set; }
    public Brand? Brand { get; set; } = null; //bu sekildede yapabiliriz: public Brand Brand { get; set; } = null!;

}
