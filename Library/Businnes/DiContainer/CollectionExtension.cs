using KUSYS_Demo.Business.Concrete;
using KUSYS_Demo.Business.Interfaces;
using KUSYS_Demo.DataAccess.Interfaces;
using KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Repository;

using Microsoft.Extensions.DependencyInjection;

namespace KUSYS_Demo.Business.DiContainer
{
    public static class CollectionExtension
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<IStudentService, StudentManager>();

            services.AddScoped<IStudentDal, EfStudentRepository>();
            services.AddScoped<ICourseDal, EfCourseRepository>();
        }
    }
}
