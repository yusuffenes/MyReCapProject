using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // generic constraint
    // class : refarans tip
    // T IEntity olabilir ya da IEntity imlemnte eden bir class olabilir  
    // new() : new'lenebilir olmaladır yani IEntity interface olduğu için kullanılamaz.
    public interface IEntityRepository<T> where T : class, IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);

    }
}
