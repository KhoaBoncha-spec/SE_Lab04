using System;
using BLL; // Gọi tầng BLL

namespace WebUI
{
    public partial class Login : System.Web.UI.Page
    {
        // Khởi tạo UserService từ BLL (Đảm bảo bạn đã có class UserService và hàm CheckLogin bên project BLL)
        private readonly UserService _userService = new UserService();

        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            // Kiểm tra đăng nhập
            if (_userService.CheckLogin(user, pass))
            {
                Response.Redirect("MainForm.aspx");
            }
            else
            {
                lblError.Text = "Invalid username or password!";
            }
        }
    }
}