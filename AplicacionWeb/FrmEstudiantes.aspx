<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmEstudiantes.aspx.cs" Inherits="AplicacionWeb.FrmEstudiantes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMain" runat="server">
    <div class="container">

         <%-- Banner inicial de la pagina --%>
        <div class="mt-5 text-center">
            <h3>Estudiantes</h3>
        </div>

         <%-- Cuadro de busqueda y botones para agregar o buscar --%>
        <div class="mt-3 d-inline-flex gap-3">
            <asp:TextBox ID="txtBuscar" class="form-control" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" class="btn btn-primary" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <asp:Button ID="btnGuardar" class="btn btn-primary" runat="server" Text="Guardar Nuevo" OnClick="btnGuardar_Click" />
        </div>
       
         <%-- Data grid que nos mostrara la informacion --%>
        <div>
            <asp:GridView ID="grdEstudiantes" class="mt-4" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="7" Width="100%" OnPageIndexChanging="grdEstudiantes_PageIndexChanging">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminar" runat="server" CommandArgument='<%# Eval("id_estudiante").ToString() %>' CommandName="Eliminar" OnCommand="lnkEliminar_Command">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkModificar" runat="server" CommandArgument='<%# Eval("id_estudiante").ToString() %>' CommandName="Modificar" OnCommand="lnkModificar_Command">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
