<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPagePrincipal.Master" CodeBehind="index.aspx.vb" Inherits="Agenda.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 512px;
            height: 512px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img class="auto-style1" src="Imagens/livro-de-visitas.png" /><asp:Image ID="Image1" runat="server" />
</asp:Content>
