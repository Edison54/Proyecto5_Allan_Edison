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
    public partial class FrmProfesores : System.Web.UI.Page
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
            BLProfesor logica = new BLProfesor(clsConfiguracion.getConnectionString);
            DataSet DSProfesores;

            try
            {
                DSProfesores = logica.ListarProfesores(condicion, orden);
                grdProfesores.DataSource = DSProfesores;
                grdProfesores.DataMember = DSProfesores.Tables[0].TableName;
                grdProfesores.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void grdProfesores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProfesores.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Al borrar el otro formulario determina que esta vacio y va agregar uno nuevo
            Session.Remove("id_profesor");

            //Redireccionamos al otro formulario
            Response.Redirect("FrmAgregarProfesor.aspx");
        }

        protected void lnkModificar_Command(object sender, CommandEventArgs e)
        {
            Session["id_profesor"] = e.CommandArgument.ToString();

            //Redireccionamos al otro formulario
            Response.Redirect("FrmAgregarProfesor.aspx");
        }

        protected void lnkEliminar_Command(object sender, CommandEventArgs e)
        {
            //Generamos las variables necesarias para trabajar
            int id = int.Parse(e.CommandArgument.ToString());
            BLProfesor logica = new BLProfesor(clsConfiguracion.getConnectionString);
            EntidadProfesor profesor;
            //Intentamos eliminar los datos y en base a la respuesta se muestran los mensajes necesarios 
            try
            {
                profesor = logica.ObtenerProfesor(id);
                if (profesor.IdProfesor > 0)
                {   //En caso de si eliminar
                    if (logica.Eliminar(profesor) > 0)
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('Profesor eliminado Correctamente')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);

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
    }
}