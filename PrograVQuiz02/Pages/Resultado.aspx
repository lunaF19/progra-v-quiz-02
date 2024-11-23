<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resultado.aspx.cs" Inherits="PrograVQuiz02.Pages.Resultado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Acción realizada con exito!</h1>
    <p> <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label></p>
    <a href="/Pages/ListaTelefonos.aspx">
     <button type="button">Ver telefonos</button>
    </a>
</asp:Content>
