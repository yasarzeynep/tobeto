using Core.Entities;
using System.Xml;

namespace Entities.Concrete;

public class Transmission:Entity<int>
{
    public string Name { get; set; }
    public Transmission()
    {
        
    }

    public Transmission(string name)
    {
        Name = name;
    }
}
