using KUSYS_Demo.Entities.Concrete;

namespace KUSYS_Demo.Business.Interfaces
{
    public interface IStudentCourseMapService : IGenericService<StudentCourseMap>
    {
        IEnumerable<Student> GetStudentAll();
        IEnumerable<Course> GetCourseAll();
        //bool CourseValidation(int studentId, string courseId);
    }
}
