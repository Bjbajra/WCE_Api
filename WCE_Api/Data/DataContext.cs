using Microsoft.EntityFrameworkCore;
using WCE_Api.Entities;

namespace WCE_Api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> Courses{get;set;}
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}