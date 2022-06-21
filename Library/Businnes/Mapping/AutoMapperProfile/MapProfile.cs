using AutoMapper;

using Piccus.Models;
using Piccus.Entities.Concrete;

namespace Piccus.Business.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region Course-CourseModel

            CreateMap<CourseModel, Course>();
            CreateMap<Course, CourseModel>();

            #endregion
        }
    }
}
