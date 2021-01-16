<%@ Page Language="VB" AutoEventWireup="false" CodeFile="home.aspx.vb" Inherits="home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username: 
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:Button ID="bttnSearch" runat="server" Text="Search Gist" />
            <asp:RequiredFieldValidator ID="usernameValdiator" runat="server" ErrorMessage="Please enter a username." ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
        </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        
        <br />
        <br />
        
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
