using System;
using BLL;

namespace WebUI
{
    public partial class CoursesForm : System.Web.UI.Page
    {
        // Khởi tạo Service từ tầng BLL
        private readonly CourseService _courseService = new CourseService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvCourses.DataSource = _courseService.GetAllCourses();

                gvCourses.DataBind();
            }
        }
    }
}