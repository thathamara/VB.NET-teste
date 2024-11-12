<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="Agenda.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 211px;
            height: 170px;
        }
    </style>
</head>

    <section>

    </section>
<body>
    <form id="form1" runat="server">
    <div style="height: 321px; width: 370px">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Senha" Font-Bold="True" Font-Size="Large"></asp:Label>
        <br />
        <asp:TextBox ID="TxtSenha" runat="server"></asp:TextBox>
        <asp:Button ID="BtnLogar" runat="server" Text="Logar" Font-Bold="True" />
        <br />
        <br />
    
        <img alt="" class="auto-style1" src="Imagens/livro-de-visitas.png" /></div>
    </form>
</body>
</html>
