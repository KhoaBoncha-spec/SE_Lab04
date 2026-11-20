using System;
using BLL;

namespace WebUI
{
    public partial class StudentEnrollmentsForm : System.Web.UI.Page
    {
        private readonly StudentCourseService _studentCourseService = new StudentCourseService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvEnrollments.DataSource = _studentCourseService.GetAllStudentCourses();
                gvEnrollments.DataBind();
            }
        }
    }
}