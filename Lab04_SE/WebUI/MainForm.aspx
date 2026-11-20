<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WebUI.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial;">
        <h2>Welcome to System Dashboard</h2>
    
        <!-- Menu Strip -->
        <div style="background-color: #333; padding: 10px;">
            <asp:HyperLink ID="linkCustomer" runat="server" NavigateUrl="~/CustomerWForm.aspx" ForeColor="White" style="margin-right: 20px;">Customer Management</asp:HyperLink>
            <asp:HyperLink ID="linkProduct" runat="server" NavigateUrl="~/ProductWForm.aspx" ForeColor="White" style="margin-right: 20px;">Product Management</asp:HyperLink>
            <asp:HyperLink ID="linkSupplier" runat="server" NavigateUrl="~/SupplierWForm.aspx" ForeColor="White">Supplier Management</asp:HyperLink>
        </div>
    
        <div style="margin-top: 50px;">
            <p>Please select a module from the menu above to start working.</p>
        </div>

    <br /><br /><br /><hr />
    <asp:Label ID="lblDesigner" runat="server" Text="designed by Tran Nguyen Dang Khoa" Font-Italic="true" ForeColor="Gray"></asp:Label>
</div>
    </form>
</body>
</html>
