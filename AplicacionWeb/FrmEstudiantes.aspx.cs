using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class FrmEstudiantes : System.Web.UI.Page
    {

        //Variable global para mostrar valores con un mensaje javascript
        string mensajeScript = "";

        //Cargamos los datos al iniciar la pagina o en caso de error informamos
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        //Seleccionamos los datos y los mandamos al grid view
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            //Cargamos la informacion en el grid de la pagina
            BLEstudiante logica = new BLEstudiante(clsConfiguracion.getConnectionString);
            DataSet DSEstudiantes;

            try
            {
                DSEstudiantes = logica.ListarEstudiantes(condicion, orden);
                grdEstudiantes.DataSource = DSEstudiantes;
                grdEstudiantes.DataMember = DSEstudiantes.Tables[0].TableName;
                grdEstudiantes.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void grdEstudiantes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdEstudiantes.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
        }

        protected void lnkModificar_Command(object sender, CommandEventArgs e)
        {
            Session["id_estudiante"] = e.CommandArgument.ToString();

            //Redireccionamos al otro formulario
            Response.Redirect("FrmAgregarEstudiante.aspx");
        }

        //Buscamos en base al parametro de busca
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscamos en base al nombre y cargamos los datos en el formulario
            try
            {
                string condicion = string.Format("nombre LIKE '%{0}%'", txtBuscar.Text);
                CargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void lnkEliminar_Command(object sender, CommandEventArgs e)
        {
            //Generamos las variables necesarias para trabajar
            int id = int.Parse(e.CommandArgument.ToString());
            BLEstudiante logica = new BLEstudiante(clsConfiguracion.getConnectionString);
            EntidadEstudiante estudiante;
            //Intentamos eliminar los datos y en base a la respuesta se muestran los mensajes necesarios 
            try
            {
                estudiante = logica.ObtenerEstudiante(id);
                if (estudiante.IdEstudiante > 0)
                {   //En caso de si eliminar
                    if (logica.EliminarConSP(estudiante) > 0)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Aviso", "alert('Eliminado Correctamente');", true);
                        CargarListaDataSet();
                        txtBuscar.Text = "";
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, false);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Al borrar el otro formulario determina que esta vacio y va agregar uno nuevo
            Session.Remove("id_estudiante");

            //Redireccionamos al otro formulario
            Response.Redirect("FrmAgregarEstudiante.aspx");
        }
    }
}