using KUSYSDemo.Entities.Interfaces;

namespace KUSYSDemo.Entities.Concrete
{
    public class StudentCourseMap : BaseEntity
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
    }
}
