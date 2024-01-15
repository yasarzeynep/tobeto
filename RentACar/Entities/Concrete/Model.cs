
using Entities.Conrete;

namespace Entities.Concrete;
public class Model
{
    public int Id { get; set; }
    public int BrandId{ get; set; }
    public string Name { get; set; }
    public string Year { get; set; }
    public Brand? Brand { get; set; } = null; //bu sekildede yapabiliriz: public Brand Brand { get; set; } = null!;

}
