using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace DAL
{
    public class SchoolDbContext : DbContext
    {
        // Trỏ chính xác vào tên chuỗi kết nối trong file config
        public SchoolDbContext() : base("name=SchoolConn") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}