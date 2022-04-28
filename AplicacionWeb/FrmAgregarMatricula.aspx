<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmAgregarMatricula.aspx.cs" Inherits="AplicacionWeb.FrmAgregarMatricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMain" runat="server">
    <div class="container">
        <%-- Cada espacio de divs nos da informacion sobre lo que queremos y con validaciones necesarias para el campo --%>
        <div class="w-75 mx-auto bg-secondary p-4 mt-5 rounded text-white" runat="server">
            <div class="form-group mt-3">
                <label for="" id="lblID" runat="server">Id de la Matricula</label>
                <asp:TextBox ID="txtID" class="form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
            <div class="form-group mt-3">
                <label for="">ID Estudiante</label>
                <asp:DropDownList class="form-select w-25" runat="server" ID="cboEstudiante">
                </asp:DropDownList>
            </div>
            <div class="form-group mt-3">
                <label for="">
                    ID Curso Abierto</label>
                <asp:DropDownList class="form-select w-25" runat="server" ID="cboCursoAbierto">
                </asp:DropDownList>
            </div>
            <div class="form-group mt-3">
                <label for="">
                    Costo</label>
                <asp:TextBox ID="txtCosto" class="form-control w-25" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                    ControlToValidate="txtCosto" ErrorMessage="Telefono requerido"
                    ValidationGroup="ValidarFormulario" ForeColor="#CC9900">
                    Campo Requerido</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                    ControlToValidate="txtCosto" runat="server"
                    ErrorMessage="Solo Numeros"
                    ValidationExpression="\d+" ForeColor="#CC9900" ValidationGroup="ValidarFormulario">
                    Sin letras..</asp:RegularExpressionValidator>
            </div>
            <div class="form-group mt-3">
                <label for="">Estado</label>
                <asp:DropDownList class="form-select w-25" runat="server" ID="cboEstado">
                    <asp:ListItem>PENDIENTE</asp:ListItem>
                    <asp:ListItem>CANCELADA</asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:Button ID="btnGuardar" class="btn btn-primary mt-3" runat="server" Text="Guardar" OnClick="btnGuardar_Click" ValidationGroup="ValidarFormulario" />
            <asp:Button ID="btnCancelar" class="btn btn-primary mt-3" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </div>
    </div>
</asp:Content>
