using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class StudentCourseRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public List<StudentCourse> GetAllStudentCourses()
        {
            return _context.StudentCourses.ToList();
        }
    }
}