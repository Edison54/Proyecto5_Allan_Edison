using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class FrmAgregarAdmin : System.Web.UI.Page
    {
        //Variable global para mostrar valores con un mensaje javascript
        string mensajeScript;

        //Metodo para limpiar el formulario
        public void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCargo.Text = "";
            cboPrograma.SelectedIndex = 0;
        }

        //Por medio de LinQ cargamos informacion solicitada en los combo box
        private void cargarNombresProgramas()
        {
            InstitutoDataContext db = new InstitutoDataContext();
            var consulta = from programa in db.programa
                           select new
                           {
                               programa.id_programa,
                               programa.nombre
                           };
            cboPrograma.DataTextField = "nombre";
            cboPrograma.DataValueField = "id_programa";
            cboPrograma.DataSource = consulta;
            cboPrograma.DataBind();
        }

        //Cargamos los datos al iniciar la pagina o en caso de error informamos
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarNombresProgramas();

            //Generamos las variables necesarias
            EntidadAdministrativo administrativo;
            BLAdministrativo logica = new BLAdministrativo(clsConfiguracion.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {   //Nos traemos los datos del cliente
                    if (Session["id_administrativo"] != null)
                    {
                        identificacion = int.Parse(Session["id_administrativo"].ToString());
                        administrativo = logica.ObtenerAdmin(identificacion);
                        if (administrativo.IdAdmin > 0)
                        {
                            txtID.Text = administrativo.IdAdmin.ToString();
                            cboPrograma.SelectedValue = administrativo.IdPrograma.ToString();
                            txtNombre.Text = administrativo.Nombre;
                            txtCorreo.Text = administrativo.Correo;
                            txtDireccion.Text = administrativo.Direccion;
                            txtTelefono.Text = administrativo.Telefono.ToString();
                            txtCargo.Text = administrativo.Cargo;
                            txtDepartamento.Text = administrativo.Departamento;

                            lblID.Visible = true;
                            txtID.Visible = true;
                        }
                        else
                        {   //En caso de no ubicarlo
                            mensajeScript = string.Format("javascript:mostrarMensaje" +
                                "('Admin no encontrado')");
                            ScriptManager.RegisterStartupScript(this, typeof(string),
                                "MensajeRetorno", mensajeScript, true);
                        }
                    }
                    else
                    {
                        Limpiar();
                        txtID.Text = "-1";
                        lblID.Visible = false;
                        txtID.Visible = false;
                    }
                }
            }   //En caso de un error
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                Response.Redirect("Default.aspx");
            }
        }

        //Generamos una entidad para luego poder insertar
        private EntidadAdministrativo generarEntidad()
        {
            EntidadAdministrativo administrativo = new EntidadAdministrativo();

            //Si hay algo en la variable de sesion
            if (Session["id_administrativo"] != null)
            {
                administrativo.IdAdmin = int.Parse(Session["id_administrativo"].ToString());
            } //Si no hay nada en la variable de sesion es un admin nuevo
            else
            {
                administrativo.IdAdmin = -1;
            }

            //Los demas datos siempre se toman de los cuadros de texto: 
            administrativo.IdPrograma = Convert.ToInt32(cboPrograma.SelectedValue);
            administrativo.Nombre = txtNombre.Text;
            administrativo.Correo = txtCorreo.Text;
            administrativo.Direccion = txtDireccion.Text;
            administrativo.Telefono = Convert.ToInt32(txtTelefono.Text);
            administrativo.Cargo = txtCargo.Text;
            administrativo.Departamento = txtDepartamento.Text;

            return administrativo;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Generamos las entidades necesarias
            EntidadAdministrativo administrativo;
            BLAdministrativo logica = new BLAdministrativo(clsConfiguracion.getConnectionString);
            int resultado = 0;

            try
            {
                administrativo = generarEntidad();
                //Si el admin ya existe, se modifica
                if (administrativo.IdAdmin > 0)
                {
                    resultado = logica.Modificar(administrativo);
                }
                else
                {
                    resultado = logica.Insertar(administrativo);

                }
                //Si se logro insertar mostramos el mensaje acorde 
                if (resultado > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Operacion realizada satifactoriamente');window.location.href='FrmAdministrativo.aspx';", true);
                }
                else
                {
                    mensajeScript = string.Format("javascript:mostrarMensaje('No se pudo ejecutar la operacion')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }
            } //En caso de una excepcion se dispara
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAdministrativo.aspx");
        }
    }
}