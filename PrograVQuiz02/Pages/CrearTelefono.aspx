<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearTelefono.aspx.cs" Inherits="PrograVQuiz02.Pages.CrearTelefono" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section>
             <header>
                 <h3>Crear teléfono</h3>
             </header>
            <br />

            <asp:Label ID="lblTelefonoMarca" runat="server" Text="Marca"></asp:Label><br />
            <asp:TextBox ID="txtTelefonoMarca" runat="server" maxlength="100" required></asp:TextBox><br /><br />
        
            <asp:Label ID="lblTelefonoNombre" runat="server" Text="Nombre"></asp:Label><br />
            <asp:TextBox ID="txtTelefonoNombre" runat="server" maxlength="50" required></asp:TextBox><br /><br />

            <asp:Label ID="lblTelefonoAnnoFabricacion" runat="server" Text="Año de fabricación"></asp:Label><br />
            <asp:TextBox ID="txtTelefonoAnnoFabricacion" runat="server" type="number" min="2000" max="2025" required></asp:TextBox><br /><br />

            <asp:Label ID="lblTelefonoFechaLanzamiento" runat="server" Text="Fecha de lanzamiento"></asp:Label><br />
            <asp:TextBox ID="txtTelefonoFechaLanzamiento" runat="server" type="date"></asp:TextBox><br /><br />

            <asp:Label ID="lblTelefonoPrecio" runat="server" Text="Precio"></asp:Label><br />
            <asp:TextBox ID="txtTelefonoPrecio" runat="server" type="number" min="1" max="5000" required></asp:TextBox><br /><br />


            <asp:Button ID="btnCreate" runat="server" Text="Guardar" OnClick="btnCreate_Click" />
            <a href="/Pages/ListaTelefonos.aspx">
                <button type="button">Cancelar</button>
            </a>

        </section>
    </main>
</asp:Content>
