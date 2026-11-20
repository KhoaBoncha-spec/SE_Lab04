<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial; width: 300px; margin: 50px auto; border: 1px solid #ccc; padding: 20px; border-radius: 5px;">
        <h2 style="text-align: center;">School System Login</h2>
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label><br /><br />
    
        <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label><br />
        <asp:TextBox ID="txtUsername" runat="server" Width="100%"></asp:TextBox><br /><br />
    
        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="100%"></asp:TextBox><br /><br />
    
        <asp:Button ID="btnLogin" runat="server" Text="Login" Width="100%" BackColor="#4CAF50" ForeColor="White" Height="30px" OnClick="btnLogin_Click" />
    
        <br /><br /><hr />
        <asp:Label ID="lblDesigner" runat="server" Text="designed by Tran Nguyen Dang Khoa" Font-Italic="true" ForeColor="Gray" Font-Size="Small"></asp:Label>
</div>
    </form>
</body>
</html>
