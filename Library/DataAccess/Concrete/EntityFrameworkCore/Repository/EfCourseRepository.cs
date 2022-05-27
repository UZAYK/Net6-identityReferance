using KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Context;
using KUSYS_Demo.DataAccess.Interfaces;
using KUSYS_Demo.Entities.Concrete;
using System.Linq.Expressions;

namespace KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfCourseRepository : EfGenericRepository<Course>, ICourseDal
    {
        public EfCourseRepository(KusysDemoContext context) : base(context)
        {
        }
    }
}
