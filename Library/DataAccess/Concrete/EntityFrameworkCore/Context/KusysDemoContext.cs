using KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using KUSYS_Demo.Entities;
using KUSYS_Demo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KUSYS_Demo.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class KusysDemoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.\\SQLEXPRESS; Initial Catalog = KusysDemoDB; Integrated Security = True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseMap());
            modelBuilder.ApplyConfiguration(new StudentMap());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourseMap> StudentCourseMaps { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
