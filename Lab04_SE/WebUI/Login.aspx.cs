using System;
using BLL;

namespace WebUI
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly UserService _userService = new UserService();

        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_userService.Login(username, password))
            {
                // Đăng nhập thành công -> Chuyển sang MainForm (Exercise 3)
                Response.Redirect("MainForm.aspx");
            }
            else
            {
                lblError.Text = "Invalid username or password!";
            }
        }
    }
}