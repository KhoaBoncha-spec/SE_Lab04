using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class DepartmentService
    {
        private readonly DepartmentRepository _departmentRepo = new DepartmentRepository();

        public List<Department> GetAllDepartments()
        {
            return _departmentRepo.GetAllDepartments();
        }
    }
}