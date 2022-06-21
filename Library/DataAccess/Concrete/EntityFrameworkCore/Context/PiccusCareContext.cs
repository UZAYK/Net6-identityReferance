using Piccus.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Piccus.Entities;
using Piccus.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Piccus.DataAccess.Concrete.EntityFrameworkCore.Context
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

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
    }
}
