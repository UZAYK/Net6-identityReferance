using KUSYS_Demo.Entities.Concrete;
using System.Linq.Expressions;

namespace KUSYS_Demo.DataAccess.Interfaces
{
    public interface IStudentCourseMapDal : IGenericDal<StudentCourseMap>
    {
        IEnumerable<Student> GetStudentAll();
        IEnumerable<Course> GetCourseAll();
        //bool CourseValidation(Expression<Func<StudentCourseMap, bool>> expression);
        //bool CourseValidation();
    }
}
