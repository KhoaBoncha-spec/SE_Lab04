using DAL;

namespace BLL
{
    public class UserService
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public bool Login(string username, string password)
        {
            // Có thể thêm logic kiểm tra rỗng ở đây
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return false;
            return _userRepository.CheckLogin(username, password);
        }
    }
}