using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity, TEntityId> //Repository Design Pattern
    {
        public IList<TEntity> GetList(Func<TEntity, bool>? predicate =null);
        /* Fun fonksiyonları  tutabilecegimiz bir type'dır
         Jenerik yapısında en son type argümanı fonksiyonu n dönüş tipidir.
        Ondan önce gelen type argümanlrı fonksiyonun sıarasıyla parametre tiplerdir.

        Örnek kullanımlar:
        Func <TEntity, bool> predicateFunc=(TEntity entitiy)=>{return  entityName=="";}
        bool predicate (TEntity entity)
        {
        bool result=entity.Name=="";
        return result;
        }
        Func<TEntity , bool>predicateFunc=predicate;
         */
        public TEntity? Get(Func<TEntity, bool> predicate);
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
    }
}
