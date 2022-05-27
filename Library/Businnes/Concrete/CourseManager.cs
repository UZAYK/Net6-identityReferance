using System.Linq.Expressions;

using KUSYS_Demo.Business.Interfaces;
using KUSYS_Demo.DataAccess.Interfaces;
using KUSYS_Demo.Entities.Concrete;

namespace KUSYS_Demo.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        #region ctor
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        #endregion

        public void Add(Course entity)
        => _courseDal.Add(entity);

        public IEnumerable<Course> Find(Expression<Func<Course, bool>> expression)
        => _courseDal.Find(expression);

        public IEnumerable<Course> GetAll()
        => _courseDal.GetAll();

        public Course GetById(int id)
        => _courseDal.GetById(id);

        public void Remove(Course entity)
        => _courseDal.Remove(entity);
    }
}
