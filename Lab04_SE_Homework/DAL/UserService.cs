using DAL;

namespace BLL
{
    public class UserService
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public bool CheckLogin(string username, string password)
        {
            // Kiểm tra rỗng trước khi đẩy xuống cơ sở dữ liệu
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return _userRepository.CheckLogin(username, password);
        }
    }
}