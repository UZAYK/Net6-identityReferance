using Piccus.Entities.Interfaces;

namespace Piccus.Entities.Concrete
{
    public class Course : BaseEntity
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
