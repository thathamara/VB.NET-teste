<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="Agenda.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
        <br />
        <asp:TextBox ID="TxtSenha" runat="server"></asp:TextBox>
        <asp:Button ID="BtnLogar" runat="server" Text="Logar" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
