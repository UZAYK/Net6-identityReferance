using System.Linq.Expressions;
using KUSYSDemo.Entities.Interfaces;

namespace KUSYSDemo.Business.Interfaces
{
    public interface IGenericService<T> where T : class, IBaseEntity, new()
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);

    }
}
