using System;
using BLL;

namespace WebUI
{
    public partial class InstructorsForm : System.Web.UI.Page
    {
        private readonly InstructorService _instructorService = new InstructorService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvInstructors.DataSource = _instructorService.GetAllInstructors();
                gvInstructors.DataBind(); // Ép dữ liệu vẽ ra bảng
            }
        }
    }
}