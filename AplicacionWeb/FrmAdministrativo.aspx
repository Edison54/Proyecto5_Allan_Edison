<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmAdministrativo.aspx.cs" Inherits="AplicacionWeb.FrmAdministrativo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMain" runat="server">
     <div class="container">
         <%-- Banner inicial de la pagina --%>
        <div class="mt-5 text-center">
            <h3>Administrativos</h3>
        </div>
         <%-- Cuadro de busqueda y botones para agregar o buscar --%>
        <div class="mt-3 d-inline-flex gap-3">
            <asp:TextBox ID="txtBuscar" class="form-control" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" class="btn btn-primary" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <asp:Button ID="btnGuardar" class="btn btn-primary" runat="server" Text="Guardar Nuevo" OnClick="btnGuardar_Click" />
        </div>
         <%-- Data grid que nos mostrara la informacion --%>
        <div>
            <asp:GridView class="mt-3" ID="grdAdmin" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="grdAdmin_PageIndexChanging1" PageSize="7" Width="100%">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminar" runat="server" CommandArgument='<%# Eval("id_admin").ToString() %>' CommandName="Eliminar" OnCommand="lnkEliminar_Command">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkModificar" runat="server" CommandArgument='<%# Eval("id_admin").ToString() %>' CommandName="Modificar" OnCommand="lnkModificar_Command">Modificar</asp:LinkButton>
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
