using KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Context;
using KUSYS_Demo.DataAccess.Interfaces;
using KUSYS_Demo.Entities.Interfaces;
using System.Linq.Expressions;

namespace KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfGenericRepository<T> : IGenericDal<T> where T : class, IBaseEntity, new()
    {
        #region constructor transactions (dependency incjection)
        private readonly KusysDemoContext _context;
        public EfGenericRepository(KusysDemoContext context)
        {
            _context = context;
        }
        #endregion

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        => _context.Set<T>().Where(expression);

        public IEnumerable<T> GetAll()
        => _context.Set<T>().ToList();

        public T GetById(int id)
        => _context.Set<T>().Find(id);

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}