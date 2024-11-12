<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPagePrincipal.Master" CodeBehind="Contatos.aspx.vb" Inherits="Agenda.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
<br />
<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Larger" Text="Inserir novo contato"></asp:Label>
<br />
<asp:Label ID="Label3" runat="server" Text="Nome"></asp:Label>
<br />
<asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>
<br />
<asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
<br />
<asp:TextBox ID="TextBox2" runat="server" Width="209px"></asp:TextBox>
<br />
<asp:Label ID="Label5" runat="server" Text="Telefone"></asp:Label>
<br />
<asp:TextBox ID="TextBox3" runat="server" Width="209px"></asp:TextBox>
<asp:Button ID="Button1" runat="server" Text="Inserir" />
<br />
<asp:SqlDataSource ID="SqlDataSourceContatos" runat="server" ConnectionString="<%$ ConnectionStrings:aaaaaaaaaaaaaConnectionString %>" SelectCommand="SELECT DISTINCT * FROM [aaa]">
</asp:SqlDataSource>
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Lista de Contatos"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSourceContatos" ForeColor="#333333" GridLines="None" Height="355px" Width="382px">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowSelectButton="True" />
        <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
        <asp:BoundField DataField="telefone" HeaderText="telefone" SortExpression="telefone" />
    </Columns>
    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <SortedAscendingCellStyle BackColor="#FDF5AC" />
    <SortedAscendingHeaderStyle BackColor="#4D0000" />
    <SortedDescendingCellStyle BackColor="#FCF6C0" />
    <SortedDescendingHeaderStyle BackColor="#820000" />
</asp:GridView>
<br />
</asp:Content>
