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
    public partial class FrmBuscarCurso : Form
    {
        //Variables globales y un evento 
        public event EventHandler Aceptar;
        int vgn_id_curso;

        public FrmBuscarCurso()
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

        //Cierra la pestana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnCerrar.Enabled = false;
            this.Close();
        }

        //Minimiza la pestana
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //Selecciona los datos del registro deseado
        private void seleccionar()
        {
            if (grvCursos.SelectedRows.Count > 0)
            {
                vgn_id_curso = (int)grvCursos.SelectedRows[0].Cells[0].Value;
                Aceptar(vgn_id_curso, null);
                Close();
            }
        }
        
        //Envia los datos al formulario anterior
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            seleccionar();
        }

        //Cierra el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        //Se llama al Cargar al darle doble click al elemento en el Grid
        private void grvCursos_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }

        //Cargara los datos en el grid de la tabla matricula mediante un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {

            BLCursoAbierto logica = new BLCursoAbierto(Configuracion.getConnectionString);
            DataSet DSCurso;

            try
            {
                DSCurso = logica.ListarCursos(condicion, orden);
                grvCursos.DataSource = DSCurso;
                grvCursos.DataMember = DSCurso.Tables["curso_abierto"].TableName;
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
                    condicion = string.Format("id_curso_abierto like '%{0}%'", txtBuscar.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir parte del ID a buscar", "Atencion",
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

        //Al cargar el formulario
        private void FrmBuscarCurso_Load(object sender, EventArgs e)
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
    }
}
