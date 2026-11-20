using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    [Table("tblStudentCourses")]
    public class StudentCourse
    {
        // Khai báo khóa chính thứ nhất
        [Key, Column(Order = 0)]
        public int StudentID { get; set; }

        // Khai báo khóa chính thứ hai
        [Key, Column(Order = 1)]
        public int CourseID { get; set; }
    }
}