<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h2>Login System</h2>
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label><br />
    
        <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br /><br />
    
        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />
    
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    
    <br /><br /><hr />
    <asp:Label ID="lblDesigner" runat="server" Text="designed by Tran Nguyen Dang Khoa" Font-Italic="true" ForeColor="Gray"></asp:Label>
</div>
    </form>
</body>
</html>
