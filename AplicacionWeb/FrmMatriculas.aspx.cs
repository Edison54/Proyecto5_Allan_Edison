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
    public partial class FrmMatriculas : System.Web.UI.Page
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
                    CargarListaProgramas();
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
            BLMatricula logica = new BLMatricula(clsConfiguracion.getConnectionString);
            DataSet DSMatriculas;

            try
            {
                DSMatriculas = logica.ListarMatriculas(condicion, orden);
                grdMatriculas.DataSource = DSMatriculas;
                grdMatriculas.DataMember = DSMatriculas.Tables[0].TableName;
                grdMatriculas.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Seleccionamos los datos y los mandamos al grid view
        private void CargarListaProgramas(string condicion = "", string orden = "")
        {
            //Cargamos la informacion en el grid de la pagina
            BLPrograma logica = new BLPrograma(clsConfiguracion.getConnectionString);
            DataSet DSProgramas;

            try
            {
                DSProgramas = logica.ListarProgramas(condicion, orden);
                grdProgramas.DataSource = DSProgramas;
                grdProgramas.DataMember = DSProgramas.Tables[0].TableName;
                grdProgramas.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Buscamos en base al parametro de busca
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscamos en base al nombre y cargamos los datos en el formulario
            try
            {
                string condicion = string.Format("id_estudiante LIKE '%{0}%'", txtBuscar.Text);
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
            Session.Remove("id_matricula");

            //Redireccionamos al otro formulario
            Response.Redirect("FrmAgregarMatricula.aspx");
        }

        protected void grdMatriculas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdMatriculas.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
        }

        protected void lnkModificar_Command(object sender, CommandEventArgs e)
        {
            Session["id_matricula"] = e.CommandArgument.ToString();

            //Redireccionamos al otro formulario
            Response.Redirect("FrmAgregarMatricula.aspx");
        }
    }
}