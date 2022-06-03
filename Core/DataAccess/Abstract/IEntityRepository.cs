using Core.Entities.Abstract;
using System.Linq.Expressions;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}