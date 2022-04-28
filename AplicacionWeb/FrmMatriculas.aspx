<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmMatriculas.aspx.cs" Inherits="AplicacionWeb.FrmMatriculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMain" runat="server">
    <div class="container">

         <%-- Banner inicial de la pagina --%>
        <div class="mt-5 text-center">
            <h3>Matriculas</h3>
        </div>

         <%-- Cuadro de busqueda y botones para agregar o buscar --%>
        <div class="mt-3 d-inline-flex gap-3">
            <asp:TextBox ID="txtBuscar" class="form-control" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" class="btn btn-primary" runat="server" Text="Buscar por ID Estudiante" OnClick="btnBuscar_Click" />
             <asp:Button ID="btnGuardar" class="btn btn-primary" runat="server" Text="Agregar Nueva Matricula" OnClick="btnGuardar_Click" />
        </div>
        
         <%-- Data grid que nos mostrara la informacion --%>
        <asp:GridView class="mt-3" runat="server" ID="grdMatriculas" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnPageIndexChanging="grdMatriculas_PageIndexChanging" ShowFooter="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField></asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkModificar" runat="server" CommandArgument='<%# Eval("id_matricula").ToString() %>' CommandName="Modificar" OnCommand="lnkModificar_Command">Modificar</asp:LinkButton>
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

        <div class="mt-5 text-center">
            <h3>Programas Disponibles</h3>
        </div>
        
         <%-- Data grid que nos mostrara la informacion --%>
        <asp:GridView class="text-center mt-3" ID="grdProgramas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True" Width="100%">
            <AlternatingRowStyle BackColor="White" />
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
</asp:Content>
