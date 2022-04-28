using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp2_AllanMadriz
{
    public partial class FrmProgramas : Form
    {
        //Creamos una variable global que llevara el nombre de matriculaRegistrado
        public FrmProgramas()
        {
            InitializeComponent();
        }

        //Cargara los datos en el grid de la tabla matricula mediante un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLPrograma logica = new BLPrograma(Configuracion.getConnectionString);
            DataSet DSProgramas;

            try
            {
                DSProgramas = logica.ListarProgramas(condicion, orden);
                grvCursos.DataSource = DSProgramas;
                grvCursos.DataMember = DSProgramas.Tables["Programa"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton de cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnCerrar.Enabled = false;
            this.Close();
        }

        //Boton de minimizar el formulario
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Metodo de carga del formulario 
        private void FrmProgramas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton de minimizar el formulario
        private void btnAbrirCursos_Click(object sender, EventArgs e)
        {
            FrmCursoAbierto frm = new FrmCursoAbierto();
            frm.Show();
        }
    }
}
