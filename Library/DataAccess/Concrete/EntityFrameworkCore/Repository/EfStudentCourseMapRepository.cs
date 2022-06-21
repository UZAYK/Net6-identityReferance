using KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Context;
using KUSYSDemo.DataAccess.Interfaces;
using KUSYSDemo.Entities.Concrete;
using System.Linq.Expressions;

namespace KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfStudentCourseMapRepository : EfGenericRepository<StudentCourseMap>, IStudentCourseMapDal
    {
        private readonly PiccusCareContext _context;
        public EfStudentCourseMapRepository(PiccusCareContext context) : base(context)
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
