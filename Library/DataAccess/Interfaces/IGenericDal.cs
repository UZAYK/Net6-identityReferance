using Piccus.Entities;
using Piccus.Entities.Interfaces;
using System.Linq.Expressions;

namespace Piccus.DataAccess.Interfaces
{
    public interface IGenericDal<T> where T : class, IBaseEntity, new()
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
