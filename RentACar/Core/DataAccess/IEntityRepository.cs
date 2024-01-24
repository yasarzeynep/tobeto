using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity, TEntityId> //Repository Design Pattern
    {
        public IList<TEntity> GetList(Func<TEntity, bool>? predicate =null);

        public TEntity? Get(Func<TEntity, bool> predicate);
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
    }
}
