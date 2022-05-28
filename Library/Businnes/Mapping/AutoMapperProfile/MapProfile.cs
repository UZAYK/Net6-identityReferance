using AutoMapper;

using KUSYS_Demo.Models;
using KUSYS_Demo.Entities.Concrete;
using KUSYS_Demo.Models.StudentCourseMap;

namespace KUSYS_Demo.Business.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region Course-CourseModel

            CreateMap<CourseModel, Course>();
            CreateMap<Course, CourseModel>();

            #endregion

            #region Student-StudentModel

            CreateMap<StudentModel, Student>();
            CreateMap<Student, StudentModel>();

            #endregion

            #region StudentCourseAddMap-StudentCourseMapModel

            CreateMap<StudentCourseMapAddModel, StudentCourseMap>();
            CreateMap<StudentCourseMap, StudentCourseMapAddModel>();

            #endregion 
            
            #region StudentCourseListMap-StudentCourseMapModel

            CreateMap<StudentCourseMapListModel, StudentCourseMap>();
            CreateMap<StudentCourseMap, StudentCourseMapListModel>();

            #endregion
        }
    }
}
