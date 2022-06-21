using KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using KUSYSDemo.Entities;
using KUSYSDemo.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class PiccusCareContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.\\SQLEXPRESS; Initial Catalog = PiccusCareDB; Integrated Security = True");
            base.OnConfiguring(optionsBuilder);
        }

        //public PiccusCareContext(DbContextOptions<PiccusCareContext> options) : base(options)
        //{
        //}

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
