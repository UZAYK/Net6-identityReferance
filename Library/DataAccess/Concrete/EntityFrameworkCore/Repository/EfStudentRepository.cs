using KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Context;
using KUSYS_Demo.DataAccess.Interfaces;
using KUSYS_Demo.Entities.Concrete;

namespace KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfStudentRepository : EfGenericRepository<Student>, IStudentDal
    {
        public EfStudentRepository(KusysDemoContext context) : base(context)
        {
        }
    }
}
