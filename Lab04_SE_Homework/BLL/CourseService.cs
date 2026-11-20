using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class CourseService
    {
        private readonly CourseRepository _courseRepo = new CourseRepository();

        public List<Course> GetAllCourses()
        {
            return _courseRepo.GetAllCourses();
        }
    }
}