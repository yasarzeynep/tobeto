using Core.Entities;
namespace Entities.Conrete;
public class Brand : Entity<int>
{
    public string Name { get; set; }

    public Brand()
    {
    }
    public Brand(string name)
    {
        Name = name;
    }
}
