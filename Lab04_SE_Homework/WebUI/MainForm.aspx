<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WebUI.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial; padding: 20px;">
            <h2>School Management Dashboard</h2>
    
            <!-- Thanh Menu Navigation -->
            <div style="background-color: #2c3e50; padding: 15px; border-radius: 5px;">
                <asp:HyperLink ID="linkStudent" runat="server" NavigateUrl="~/StudentsForm.aspx" ForeColor="White" style="margin-right: 20px; text-decoration: none; font-weight: bold;">Students</asp:HyperLink>
                <asp:HyperLink ID="linkCourse" runat="server" NavigateUrl="~/CoursesForm.aspx" ForeColor="White" style="margin-right: 20px; text-decoration: none; font-weight: bold;">Courses</asp:HyperLink>
                <asp:HyperLink ID="linkInstructor" runat="server" NavigateUrl="~/InstructorsForm.aspx" ForeColor="White" style="margin-right: 20px; text-decoration: none; font-weight: bold;">Instructors</asp:HyperLink>
                <asp:HyperLink ID="linkDepartment" runat="server" NavigateUrl="~/DepartmentsForm.aspx" ForeColor="White" style="margin-right: 20px; text-decoration: none; font-weight: bold;">Departments</asp:HyperLink>
                <asp:HyperLink ID="linkEnrollment" runat="server" NavigateUrl="~/StudentEnrollmentsForm.aspx" ForeColor="White" style="margin-right: 20px; text-decoration: none; font-weight: bold;">Enrollments</asp:HyperLink>
                <asp:HyperLink ID="linkLogout" runat="server" NavigateUrl="~/Login.aspx" ForeColor="#e74c3c" style="float: right; text-decoration: none; font-weight: bold;">Logout</asp:HyperLink>
            </div>
    
            <div style="margin-top: 50px;">
                <h3>Welcome to the system! Please select a module from the menu above.</h3>
            </div>

            <br /><br /><br /><hr />
            <asp:Label ID="lblDesigner" runat="server" Text="designed by Tran Nguyen Dang Khoa" Font-Italic="true" ForeColor="Gray"></asp:Label>
        </div>
    </form>
</body>
</html>
