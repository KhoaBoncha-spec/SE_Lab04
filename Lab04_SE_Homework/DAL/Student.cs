using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    // Ép Entity Framework trỏ đúng vào bảng tblStudents
    [Table("tblStudents")]
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string City { get; set; }

        public int Age { get; set; }

        public int YearOfEnroll { get; set; }

        public string Major { get; set; }

        // GPA trong SQL không có NOT NULL (có thể rỗng), nên dùng decimal?
        public decimal? GPA { get; set; }
    }
}