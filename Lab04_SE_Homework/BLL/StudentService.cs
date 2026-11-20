using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository = new StudentRepository();

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public void AddStudent(Student student)
        {
            // Nơi này sau này bạn có thể viết thêm code kiểm tra dữ liệu hợp lệ (Validation) trước khi lưu
            _studentRepository.AddStudent(student);
        }
    }
}