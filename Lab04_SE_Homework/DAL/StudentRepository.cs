using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class StudentRepository
    {
        // Khởi tạo cầu nối Entity Framework
        private readonly SchoolDbContext _context = new SchoolDbContext();

        // Hàm lấy danh sách sinh viên
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        // Hàm thêm sinh viên mới
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges(); // Lệnh này tự động sinh ra SQL INSERT và lưu vào DB
        }
    }
}