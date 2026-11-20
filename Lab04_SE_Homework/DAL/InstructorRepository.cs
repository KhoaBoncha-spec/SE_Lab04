using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class InstructorRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public List<Instructor> GetAllInstructors()
        {
            return _context.Instructors.ToList();
        }
    }
}