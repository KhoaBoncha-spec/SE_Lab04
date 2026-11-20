using System.Linq;

namespace DAL
{
    public class UserRepository
    {
        private readonly Exer1DbContext _context;
        public UserRepository()
        {
            _context = new Exer1DbContext();
        }

        public bool CheckLogin(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null; // Trả về true nếu tìm thấy tài khoản
        }
    }
}