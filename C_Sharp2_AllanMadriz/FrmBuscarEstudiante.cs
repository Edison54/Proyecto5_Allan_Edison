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
    public partial class FrmBuscarEstudiante : Form
    {
        //Variables globales y un evento 
        public event EventHandler Aceptar;
        int vgn_id_estudiante;

        public FrmBuscarEstudiante()
        {
            InitializeComponent();
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cargara los datos en el grid de la tabla matricula mediante un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {

            BLEstudiante logica = new BLEstudiante(Configuracion.getConnectionString);
            DataSet DSEstudiantes;

            try
            {
                DSEstudiantes = logica.ListarEstudiantes(condicion, orden);
                grvEstudiantes.DataSource = DSEstudiantes;
                grvEstudiantes.DataMember = DSEstudiantes.Tables["Estudiante"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton buscar que nos trae datos segun las letras ingresadas
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    condicion = string.Format("nombre like '%{0}%'", txtBuscar.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir parte del nombre a buscar", "Atencion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscar.Focus();
                }
                CargarListaDataSet(condicion);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Selecciona los datos del registro deseado
        private void seleccionar()
        {
            if (grvEstudiantes.SelectedRows.Count > 0)
            {
                vgn_id_estudiante = (int)grvEstudiantes.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_estudiante, null);
                Close();
            }
        }

        //Envia los datos al formulario anterior
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            seleccionar();
        }

        //Se llama al Cargar al darle doble click al elemento en el Grid
        private void grvEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }

        //Cierra la pestana
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        //Al cargar el formulario
        private void FrmBuscarEstudiante_Load(object sender, EventArgs e)
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

        //Minimiza la pestana
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
