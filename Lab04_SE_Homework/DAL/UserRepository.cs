using System.Linq;

namespace DAL
{
    // Bắt buộc phải là public class để BLL có thể gọi được
    public class UserRepository
    {
        private readonly SchoolDbContext _context = new SchoolDbContext();

        public bool CheckLogin(string username, string password)
        {
            // Tìm kiếm tài khoản khớp với username và password
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null; // Trả về true nếu tìm thấy
        }
    }
}