<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentsForm.aspx.cs" Inherits="WebUI.StudentsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial; padding: 20px;">
    <h2>Student Management Module</h2>
    
    <!-- Nút quay lại màn hình chính -->
    <asp:HyperLink ID="linkBack" runat="server" NavigateUrl="~/MainForm.aspx" ForeColor="Blue"><< Back to Dashboard</asp:HyperLink>
    <hr />

    <div style="display: flex; gap: 20px;">
        <!-- Khung nhập liệu (Bên trái) -->
        <div style="width: 300px; padding: 15px; border: 1px solid #ccc; background-color: #f9f9f9;">
            <h3>Student Details</h3>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label><br /><br />

            Name:<br />
            <asp:TextBox ID="txtName" runat="server" Width="100%"></asp:TextBox><br /><br />
            
            Date of Birth (yyyy-mm-dd):<br />
            <asp:TextBox ID="txtDOB" runat="server" Width="100%"></asp:TextBox><br /><br />

            City:<br />
            <asp:TextBox ID="txtCity" runat="server" Width="100%"></asp:TextBox><br /><br />
            
            Major:<br />
            <asp:TextBox ID="txtMajor" runat="server" Width="100%"></asp:TextBox><br /><br />

            <asp:Button ID="btnAdd" runat="server" Text="Add Student" BackColor="#4CAF50" ForeColor="White" />
        </div>

        <!-- Khung hiển thị danh sách (Bên phải) -->
        <div style="flex-grow: 1;">
            <h3>Student List</h3>
            <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="True" CellPadding="8" ForeColor="#333333" GridLines="None" Width="100%">
                <AlternatingRowStyle BackColor="White" />
                <HeaderStyle BackColor="#2c3e50" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:GridView>
        </div>
    </div>
</div>
    </form>
</body>
</html>
