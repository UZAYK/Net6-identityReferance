using System.Linq.Expressions;
using KUSYS_Demo.Entities.Interfaces;

namespace KUSYS_Demo.Business.Interfaces
{
    public interface IGenericService<T> where T : class, IBaseEntity, new()
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Remove(T entity);
    }
}
