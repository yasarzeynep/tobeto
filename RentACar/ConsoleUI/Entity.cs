namespace ConsoleUI;

internal class Entity
{
    internal int Id { get;  }
    internal DateTime CreatedAt { get;  } //Read-Only Property
    internal DateTime? LastUpdateAt { get; set; }

    // internal readonly string CreatedAt;//Read-Only Field

    public Entity()
    {
        Id = generateId();
        CreatedAt = DateTime.UtcNow;//Read-only özellikleri kurucu metotlarda ilk degerini verebiliyoruz.Fakar dısarıda veremıyoruz
        Console.WriteLine("Bir Entity() oluşturuldu.");

    }
    public Entity(int id) //:this()
    {
        Id = id;
        CreatedAt = DateTime.UtcNow;//Read-only özellikleri kurucu metotlarda ilk degerini verebiliyoruz.Fakar dısarıda veremıyoruz
     
        Console.WriteLine("Bir Entity(id) oluşturuldu.");
    } 
    protected virtual int generateId()
    {
        return ++EntityIdHelper.LastId;
    }
}
internal static class EntityIdHelper
{
    public static int LastId { get; set; } = 0;
}
