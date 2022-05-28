using KUSYS_Demo.Entities;
using KUSYS_Demo.Entities.Interfaces;
using System.Linq.Expressions;

namespace KUSYS_Demo.DataAccess.Interfaces
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
