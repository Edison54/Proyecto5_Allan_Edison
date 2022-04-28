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
    public partial class FrmAgregarMatricula : System.Web.UI.Page
    {

        //Variable global para mostrar valores con un mensaje javascript
        string mensajeScript;

        //Por medio de LinQ cargamos informacion solicitada en los combo box
        private void cargarNombresEstudiantes()
        {
            InstitutoDataContext db = new InstitutoDataContext();
            var consulta = from estudiante in db.estudiante                        
                           select new
                           {
                               estudiante.id_estudiante,
                               estudiante.nombre
                           };
            cboEstudiante.DataTextField = "nombre";
            cboEstudiante.DataValueField = "id_estudiante";
            cboEstudiante.DataSource = consulta;
            cboEstudiante.DataBind();
        }

        //Metodo para limpiar el formulario
        public void Limpiar()
        {
            txtID.Text = "";
            txtCosto.Text = "";
            cboEstado.SelectedIndex = 0;
            cboEstudiante.SelectedIndex = 0;
            cboCursoAbierto.SelectedIndex = 0;
        }

        //Por medio de LinQ cargamos informacion solicitada en los combo box
        private void cargarNombresCursosAbiertos()
        {
            InstitutoDataContext db = new InstitutoDataContext();
            var consulta = from c in db.curso
                           join ca in db.curso_abierto
                           on c.id_curso equals ca.id_curso
                           select new
                           {
                              c.curso1,
                              ca.id_curso_abierto
                           };

            cboCursoAbierto.DataTextField = "curso1";
            cboCursoAbierto.DataValueField = "id_curso_abierto";
            cboCursoAbierto.DataSource = consulta;
            cboCursoAbierto.DataBind();
        }

        //Cargamos los datos al iniciar la pagina o en caso de error informamos
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarNombresEstudiantes();
            cargarNombresCursosAbiertos();

            //Generamos las variables necesarias
            EntidadMatricula matricula;
            BLMatricula logica = new BLMatricula(clsConfiguracion.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {   //Nos traemos los datos del cliente
                    if (Session["id_matricula"] != null)
                    {
                        identificacion = int.Parse(Session["id_matricula"].ToString());
                        matricula = logica.ObtenerMatricula(identificacion);
                        if (matricula.IdMatricula > 0)
                        {
                            txtID.Text = matricula.IdMatricula.ToString();
                            cboEstudiante.SelectedValue = matricula.IdEstudiante.ToString();
                            cboCursoAbierto.SelectedValue = matricula.Id_curso_abierto.ToString();
                            txtCosto.Text = matricula.Costo.ToString();
                            cboEstado.SelectedValue = matricula.Estado;

                            lblID.Visible = true;
                            txtID.Visible = true;
                        }
                        else
                        {   //En caso de no ubicarlo
                            mensajeScript = string.Format("javascript:mostrarMensaje" +
                                "('Cliente no encontrado')");
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
        private EntidadMatricula generarEntidad()
        {
            EntidadMatricula matricula = new EntidadMatricula();

            //Si hay algo en la variable de sesion
            if (Session["id_matricula"] != null)
            {
                matricula.IdMatricula = int.Parse(Session["id_matricula"].ToString());
            } //Si no hay nada en la variable de sesion es un cliente nuevo
            else
            {
                matricula.IdMatricula = -1;
            }

            //Los demas datos siempre se toman de los cuadros de texto: 
            matricula.Costo = Convert.ToInt32(txtCosto.Text);
            matricula.Estado = cboEstado.Text;
            matricula.IdEstudiante = Convert.ToInt32(cboEstudiante.SelectedValue);
            matricula.Id_curso_abierto = Convert.ToInt32(cboCursoAbierto.SelectedValue);

            return matricula;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Generamos las entidades necesarias
            EntidadMatricula matricula;
            BLMatricula logica = new BLMatricula(clsConfiguracion.getConnectionString);
            int resultado = 0;

            try
            {
                matricula = generarEntidad();
                //Si la matricula ya existe, se modifica
                if (matricula.IdMatricula > 0)
                {
                    resultado = logica.Modificar(matricula);
                }
                else
                {
                        resultado = logica.Insertar(matricula);

                }
                //Si se logro insertar mostramos el mensaje acorde 
                if (resultado > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Operacion realizada satifactoriamente');window.location.href='FrmMatriculas.aspx';", true);
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
            Response.Redirect("FrmMatriculas.aspx");
        }
    }
}