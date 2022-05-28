using KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Context;
using KUSYS_Demo.DataAccess.Interfaces;
using KUSYS_Demo.Entities.Concrete;
using System.Linq.Expressions;

namespace KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfStudentCourseMapRepository : EfGenericRepository<StudentCourseMap>, IStudentCourseMapDal
    {
        private readonly KusysDemoContext _context;
        public EfStudentCourseMapRepository(KusysDemoContext context) : base(context)
        {
            _context = context;
        }

        //public bool CourseValidation(int studentId, string courseId)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CourseValidation(Expression<Func<StudentCourseMap, bool>> expression)
        // => _context.Set<StudentCourseMap>().Where(expression).;

        public IEnumerable<Course> GetCourseAll()
        => _context.Set<Course>().ToList();

        public IEnumerable<Student> GetStudentAll()
         => _context.Set<Student>().ToList();
    }
}
