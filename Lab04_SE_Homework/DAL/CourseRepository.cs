using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class CourseRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }
    }
}