using Piccus.DataAccess.Concrete.EntityFrameworkCore.Context;
using Piccus.DataAccess.Interfaces;
using Piccus.Entities.Interfaces;
using System.Linq.Expressions;

namespace Piccus.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfGenericRepository<T> : IGenericDal<T> where T : class, IBaseEntity, new()
    {
        #region constructor transactions (dependency incjection)
        private readonly PiccusCareContext _context;
        public EfGenericRepository(PiccusCareContext context)
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