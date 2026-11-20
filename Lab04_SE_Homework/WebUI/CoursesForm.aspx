<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoursesForm.aspx.cs" Inherits="WebUI.CoursesForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Course Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial; padding: 20px;">
            <h2>Course Management Module</h2>
            <asp:HyperLink ID="linkBack" runat="server" NavigateUrl="~/MainForm.aspx" ForeColor="Blue"><< Back to Dashboard</asp:HyperLink>
            <hr />
            
            <h3>Course List</h3>
            <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="True" 
                EmptyDataText="Chưa có khóa học nào trong hệ thống hoặc chưa bơm dữ liệu vào bảng tblCourses!" 
                ShowHeaderWhenEmpty="True"
                CellPadding="8" ForeColor="#333333" GridLines="None" Width="100%">
                <AlternatingRowStyle BackColor="White" />
                <HeaderStyle BackColor="#2c3e50" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>