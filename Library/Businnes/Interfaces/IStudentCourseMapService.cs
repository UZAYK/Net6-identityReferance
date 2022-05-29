using KUSYSDemo.Entities.Concrete;

namespace KUSYSDemo.Business.Interfaces
{
    public interface IStudentCourseMapService : IGenericService<StudentCourseMap>
    {
        IEnumerable<Student> GetStudentAll();
        IEnumerable<Course> GetCourseAll();
        //bool CourseValidation(int studentId, string courseId);
    }
}
