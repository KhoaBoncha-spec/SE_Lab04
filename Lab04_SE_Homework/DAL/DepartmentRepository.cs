using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DepartmentRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }
    }
}