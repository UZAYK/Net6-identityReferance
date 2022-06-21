using Piccus.DataAccess.Concrete.EntityFrameworkCore.Context;
using Piccus.DataAccess.Interfaces;
using Piccus.Entities.Concrete;
using System.Linq.Expressions;

namespace Piccus.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfCourseRepository : EfGenericRepository<Course>, ICourseDal
    {
        public EfCourseRepository(PiccusCareContext context) : base(context)
        {
        }
    }
}
