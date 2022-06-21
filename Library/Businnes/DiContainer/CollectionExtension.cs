using Piccus.Business.Concrete;
using Piccus.Business.Interfaces;
using Piccus.DataAccess.Interfaces;
using Piccus.DataAccess.Concrete.EntityFrameworkCore.Repository;

using Microsoft.Extensions.DependencyInjection;

namespace Piccus.Business.DiContainer
{
    public static class CollectionExtension
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseManager>();
      
            services.AddScoped<ICourseDal, EfCourseRepository>(); 
       
        }
    }
}
