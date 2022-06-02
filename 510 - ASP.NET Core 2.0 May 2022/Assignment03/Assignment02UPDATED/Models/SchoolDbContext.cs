using Microsoft.EntityFrameworkCore;

namespace Assignment02.Models
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<InstructorModel> Instructors { get; set; }
        public DbSet<CourseModel> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"DataSource=C:\Program Files\Git\repos\Assignments\510 - ASP.NET Core 2.0 May 2022\Assignment02\Assignment02\Database\School.db");
    }
}
