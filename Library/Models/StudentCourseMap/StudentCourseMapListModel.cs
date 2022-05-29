using KUSYSDemo.Entities.Concrete;

namespace KUSYSDemo.Models.StudentCourseMap
{
    public class StudentCourseMapListModel
    {
        public List<Course> CourseName { get; set; }
        public List<Student> StudentName { get; set; }
        
        public List<string> CourseId { get; set; }
        public List<string> StudentId { get; set; }
    }
}
