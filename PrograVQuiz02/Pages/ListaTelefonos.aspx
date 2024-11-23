<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaTelefonos.aspx.cs" Inherits="PrograVQuiz02.Pages.ListaTelefonos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section>
            <header>
                <h3>Lista de teléfonos</h3>
                    <a class="nav-link" runat="server" href="~/Pages/CrearTelefono">
                        <button type="button">
                        Crear Telefono
                        </button>
                    </a>
                
            </header>
            <asp:GridView 
                ID="gv_Telefonos" 
                runat="server"
                AutoGenerateColumns="false"
                OnRowDataBound="gv_Telefonos_RowDataBound"
                CssClass="table table-bordered table-hover text-left"
                >
                <Columns>
                    <asp:BoundField DataField="id_Telefono" HeaderText="ID"/>
                    <asp:BoundField DataField="marca" HeaderText="Marca"/>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                    <asp:TemplateField HeaderText="Precio">
                         <ItemTemplate>
                             <asp:Label ID="precioLbl" runat="server" Text=""></asp:Label>
                         </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Lanzamiento">
                         <ItemTemplate>
                             <asp:Label ID="fechaLanzamientoLbl" runat="server" Text=""></asp:Label>
                         </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Editar">
                        <ItemTemplate>
                            <a href="EditarTelefono.aspx?id=<%# Eval("id_Telefono") %>">
                            Modificar
                            </a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

        </section>
    </main>
</asp:Content>
