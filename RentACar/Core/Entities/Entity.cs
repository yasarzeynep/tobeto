
namespace Core.Entities;

public abstract class TEntity<TId> : IEntity<TId>
{
    public TId Id { get; set ; } //
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdateAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}


    

