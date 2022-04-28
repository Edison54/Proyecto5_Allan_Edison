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
    public partial class FrmAgregarEstudiante : System.Web.UI.Page
    {
        //Variable global para mostrar valores con un mensaje javascript
        string mensajeScript;

        //Cargamos los datos al iniciar la pagina o en caso de error informamos
        protected void Page_Load(object sender, EventArgs e)
        {
            //Generamos las variables necesarias
            EntidadEstudiante estudiante;
            BLEstudiante logica = new BLEstudiante(clsConfiguracion.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {   //Nos traemos los datos del estudiante
                    if (Session["id_estudiante"] != null)
                    {
                        identificacion = int.Parse(Session["id_estudiante"].ToString());
                        estudiante = logica.ObtenerEstudiante(identificacion);
                        if (estudiante.IdEstudiante > 0)
                        {
                            txtID.Text = estudiante.IdEstudiante.ToString();
                            txtNombre.Text = estudiante.Nombre;
                            txtTelefono.Text = estudiante.Telefono.ToString();
                            txtDireccion.Text = estudiante.Direccion;
                            txtCorreo.Text = estudiante.Correo;
                            txtCedula.Text = estudiante.Cedula;

                            lblID.Visible = true;
                            txtID.Visible = true;
                        }
                        else
                        {   //En caso de no ubicarlo
                            mensajeScript = string.Format("javascript:mostrarMensaje" +
                                "('Estudiante no encontrado')");
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
        private EntidadEstudiante generarEntidadEstudiante()
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();

            //Si hay algo en la variable de sesion
            if (Session["id_estudiante"] != null)
            {
                estudiante.IdEstudiante = int.Parse(Session["id_estudiante"].ToString());
            } //Si no hay nada en la variable de sesion es un estudiante nuevo
            else
            {
                estudiante.IdEstudiante = -1;
            }

            //Los demas datos siempre se toman de los cuadros de texto: 
            estudiante.Nombre = txtNombre.Text;
            estudiante.Cedula = txtCedula.Text;
            estudiante.Correo = txtCorreo.Text;
            estudiante.Telefono = Convert.ToInt32(txtTelefono.Text);
            estudiante.Direccion = txtDireccion.Text;

            return estudiante;
        }

        //Metodo para limpiar el formulario
        public void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtCedula.Text = "";
            txtTelefono.Text = "";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmEstudiantes.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Generamos las entidades necesarias
            EntidadEstudiante estudiante;
            BLEstudiante logica = new BLEstudiante(clsConfiguracion.getConnectionString);
            int resultado = 0;

            try
            {
                estudiante = generarEntidadEstudiante();
                //Si el estudiante ya existe, se modifica
                if (estudiante.IdEstudiante > 0)
                {
                    resultado = logica.Modificar(estudiante);
                }
                else
                {

                   resultado = logica.Insertar(estudiante);
  
                }
                //Si se logro insertar mostramos el mensaje acorde 
                if (resultado > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Operacion realizada satifactoriamente');window.location.href='FrmEstudiantes.aspx';", true);
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

    }
}