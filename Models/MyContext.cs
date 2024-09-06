using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MVC_Tasks.Models
{
    public class MyContext :DbContext
    {
        public MyContext() : base()
        {
        }
        public MyContext(DbContextOptions dbContextOptions):base(dbContextOptions) {
        
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseResult> CourseResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5VIT1FL\\MSSQLSERVER02;Initial Catalog=MVC_DB_Tasks;Integrated Security=True;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
