using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class InstructorService
    {
        private readonly InstructorRepository _instructorRepo = new InstructorRepository();

        public List<Instructor> GetAllInstructors()
        {
            return _instructorRepo.GetAllInstructors();
        }
    }
}