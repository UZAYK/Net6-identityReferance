using KUSYS_Demo.Business.Interfaces;
using KUSYS_Demo.DataAccess.Interfaces;
using KUSYS_Demo.Entities.Concrete;
using System.Linq.Expressions;

namespace KUSYS_Demo.Business.Concrete
{
    public class StudentCourseMapManager : IStudentCourseMapService
    {
        #region ctor
        private readonly IStudentCourseMapDal _studentCourseMapDal;
        public StudentCourseMapManager(IStudentCourseMapDal studentCourseMapDal)
        {
            _studentCourseMapDal = studentCourseMapDal;
        }

        #endregion

        public void Add(StudentCourseMap entity)
        => _studentCourseMapDal.Add(entity);

        public IEnumerable<StudentCourseMap> Find(Expression<Func<StudentCourseMap, bool>> expression)
        => _studentCourseMapDal.Find(expression);

        public void Remove(StudentCourseMap entity)
        => _studentCourseMapDal.Remove(entity);

        public IEnumerable<StudentCourseMap> GetAll()
        => _studentCourseMapDal.GetAll();

        public StudentCourseMap GetById(int id)
        => _studentCourseMapDal.GetById(id);

        public void Update(StudentCourseMap entity)
        => _studentCourseMapDal.Update(entity);

        public IEnumerable<Student> GetStudentAll()
        => _studentCourseMapDal.GetStudentAll();

        public IEnumerable<Course> GetCourseAll()
        => _studentCourseMapDal.GetCourseAll();
    }
}
