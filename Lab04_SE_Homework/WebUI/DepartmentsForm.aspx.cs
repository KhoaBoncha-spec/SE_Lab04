using System;
using BLL;

namespace WebUI
{
    public partial class DepartmentsForm : System.Web.UI.Page
    {
        private readonly DepartmentService _departmentService = new DepartmentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvDepartments.DataSource = _departmentService.GetAllDepartments();
                gvDepartments.DataBind(); // Yêu cầu vẽ dữ liệu ra GridView
            }
        }
    }
}