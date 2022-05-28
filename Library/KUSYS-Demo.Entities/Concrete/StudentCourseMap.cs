using KUSYS_Demo.Entities.Interfaces;

namespace KUSYS_Demo.Entities.Concrete
{
    public class StudentCourseMap : BaseEntity
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
    }
}
