using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class StudentCourseService
    {
        private readonly StudentCourseRepository _studentCourseRepo = new StudentCourseRepository();

        public List<StudentCourse> GetAllStudentCourses()
        {
            return _studentCourseRepo.GetAllStudentCourses();
        }
    }
}