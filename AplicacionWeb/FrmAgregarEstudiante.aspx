<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmAgregarEstudiante.aspx.cs" Inherits="AplicacionWeb.FrmAgregarEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoMain" runat="server">
    <div class="container">
        <%-- Cada espacio de divs nos da informacion sobre lo que queremos y con validaciones necesarias para el campo --%>
        <div class="w-75 mx-auto bg-secondary p-4 mt-5 rounded text-white" runat="server">
            <div class="form-group">
                <label for="" id="lblID" runat="server">ID</label>
                <asp:TextBox ID="txtID" class="form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
            <div class="form-group mt-3 col-7">
                <label for="">Cedula Estudiante</label>
                <asp:TextBox ID="txtCedula" class="form-control w-25" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="txtCedula" ErrorMessage="Cedula requerida"
                    ValidationGroup="ValidarFormulario" ForeColor="#CC9900">Campo Requerido</asp:RequiredFieldValidator>
            </div>

            <div class="form-group mt-3">
                <label for="">Nombre</label>
                <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="txtNombre" ErrorMessage="Nombre requerida"
                    ValidationGroup="ValidarFormulario" ForeColor="#CC9900">Campo Requerido</asp:RequiredFieldValidator>
            </div>
            <div class="form-group mt-3">
                <label for="">Correo Electronico</label>
                <asp:TextBox ID="txtCorreo" class="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ControlToValidate="txtCorreo" ErrorMessage="Correo requerido"
                    ValidationGroup="ValidarFormulario" ForeColor="#CC9900">Campo Requerido</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Email no valido" ForeColor="#CC9900" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="ValidarFormulario">Email no valido</asp:RegularExpressionValidator>
            </div>
            <div class="form-group mt-3">
                <label for="">Telefono</label>
                <asp:TextBox ID="txtTelefono" class="form-control w-25" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                    ControlToValidate="txtTelefono" ErrorMessage="Telefono requerido"
                    ValidationGroup="ValidarFormulario" ForeColor="#CC9900">Campo Requerido</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                    ControlToValidate="txtTelefono" runat="server"
                    ErrorMessage="Solo Numeros"
                    ValidationExpression="\d+" ForeColor="#CC9900" ValidationGroup="ValidarFormulario">Sin letras..</asp:RegularExpressionValidator>
            </div>
            <div class="form-group mt-3">
                <label for="">Lugar de Residencia</label>
                <asp:TextBox ID="txtDireccion" class="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                    ControlToValidate="txtDireccion" ErrorMessage="Residencia requerido"
                    ValidationGroup="ValidarFormulario" ForeColor="#CC9900">Campo Requerido</asp:RequiredFieldValidator>
            </div>
            <asp:Button ID="btnGuardar" class="btn btn-primary mt-3" runat="server" Text="Guardar" OnClick="btnGuardar_Click" ValidationGroup="ValidarFormulario" />
            <asp:Button ID="btnCancelar" class="btn btn-primary mt-3" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </div>
    </div>
</asp:Content>
