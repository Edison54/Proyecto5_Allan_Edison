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
    public partial class FrmAgregarProfesor : System.Web.UI.Page
    {

        //Variable global para mostrar valores con un mensaje javascript
        string mensajeScript;

        //Cargamos los datos al iniciar la pagina o en caso de error informamos
        protected void Page_Load(object sender, EventArgs e)
        {
            //Generamos las variables necesarias
            EntidadProfesor profesor;
            BLProfesor logica = new BLProfesor(clsConfiguracion.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {   //Nos traemos los datos del cliente
                    if (Session["id_profesor"] != null)
                    {
                        identificacion = int.Parse(Session["id_profesor"].ToString());
                        profesor = logica.ObtenerProfesor(identificacion);
                        if (profesor.IdProfesor > 0)
                        {
                            txtID.Text = profesor.IdProfesor.ToString();
                            txtCedula.Text = profesor.Cedula;
                            txtNombre.Text = profesor.Nombre;
                            txtCorreo.Text = profesor.Correo;
                            txtDireccion.Text = profesor.Direccion;
                            txtTelefono.Text = profesor.Telefono.ToString();
                            txtSueldo.Text = profesor.Sueldo.ToString();
                            cboIdiomas.SelectedValue = profesor.Idioma;

                            lblID.Visible = true;
                            txtID.Visible = true;
                        }
                        else
                        {   //En caso de no ubicarlo
                            mensajeScript = string.Format("javascript:mostrarMensaje" +
                                "('Profesor no encontrado')");
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

        //Metodo para limpiar el formulario
        public void Limpiar()
        {
            txtID.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCedula.Text = "";
            txtCorreo.Text = "";
            txtSueldo.Text = "";
        }

        //Generamos una entidad para luego poder insertar
        private EntidadProfesor generarEntidad()
        {
            EntidadProfesor profesor = new EntidadProfesor();

            //Si hay algo en la variable de sesion
            if (Session["id_profesor"] != null)
            {
                profesor.IdProfesor = int.Parse(Session["id_profesor"].ToString());
            } //Si no hay nada en la variable de sesion es un cliente nuevo
            else
            {
                profesor.IdProfesor = -1;
            }

            //Los demas datos siempre se toman de los cuadros de texto: 
            profesor.Nombre = txtNombre.Text;
            profesor.Telefono = Convert.ToInt32(txtTelefono.Text);
            profesor.Direccion = txtDireccion.Text;
            profesor.Cedula = txtCedula.Text;
            profesor.Correo = txtCorreo.Text;
            profesor.Idioma = cboIdiomas.Text;
            profesor.Sueldo = Convert.ToInt32(txtSueldo.Text);

            return profesor;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Generamos las entidades necesarias
            EntidadProfesor profesor;
            BLProfesor logica = new BLProfesor(clsConfiguracion.getConnectionString);
            int resultado = 0;

            try
            {
                profesor = generarEntidad();
                //Si el cliente ya existe, se modifica
                if (profesor.IdProfesor > 0)
                {
                    resultado = logica.Modificar(profesor);
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        resultado = logica.Insertar(profesor);
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje" +
                            "('Debe agregar al menos el nombre del profesor')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        resultado = -1;
                    }
                }
                //Si se logro insertar mostramos el mensaje acorde 
                if (resultado > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Operacion realizada satifactoriamente');window.location.href='FrmProfesores.aspx';", true);
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
            Response.Redirect("FrmProfesores.aspx");
        }
    }
}