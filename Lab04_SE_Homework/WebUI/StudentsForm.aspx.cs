using System;
using BLL;

namespace WebUI
{
    public partial class StudentsForm : System.Web.UI.Page
    {
        private readonly StudentService _studentService = new StudentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Chỉ load dữ liệu ở lần đầu tiên mở trang (tránh load lại khi bấm nút)
            if (!IsPostBack)
            {
                LoadStudents();
            }
        }

        private void LoadStudents()
        {
            // Lấy danh sách sinh viên gán vào GridView và ép hiển thị
            gvStudents.DataSource = _studentService.GetAllStudents();
            gvStudents.DataBind();
        }
    }
}