using Core.Entities;
namespace Entities.Conrete;

public class Brand : Entity<int>
{
    public Brand()
    {
    }

    public string Name { get; set; }

}
