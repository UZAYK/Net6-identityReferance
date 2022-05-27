using KUSYS_Demo.Entities.Interfaces;

namespace KUSYS_Demo.Entities.Concrete
{
    public class Student : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
