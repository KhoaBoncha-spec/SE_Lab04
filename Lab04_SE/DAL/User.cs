using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    [Table("Users")] 
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}