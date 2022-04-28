using Entidades;
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
    public partial class FrmMatriculas : Form
    {
        //Creamos una variable global que llevara el nombre de matriculaRegistrado
        EntidadMatricula matriculaRegistrado;

        //Se inicia el formulario
        public FrmMatriculas()
        {
            InitializeComponent();
        }

        //Metodo para limpiar todos los campos del formulario
        private void Limpiar()
        {
            txtId.Text = string.Empty;
            txtIdCursoAbierto.Text = string.Empty;
            txtIdEstudiante.Text = string.Empty;
            txtCosto.Text = string.Empty;
            cboEstado.SelectedIndex = -1;
        }

        //Metodo para generar una entidad de matricula en caso de estar ya generada la pasa la variable matriculaRegistrado
        private EntidadMatricula GenerarEntidadMatricula()
        {
            EntidadMatricula matricula;
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                matricula = matriculaRegistrado;
            }
            else
            {
                matricula = new EntidadMatricula();
            }

            matricula.Id_curso_abierto = Convert.ToInt32(txtIdCursoAbierto.Text);
            matricula.IdEstudiante = Convert.ToInt32(txtIdEstudiante.Text);
            matricula.Estado = cboEstado.Text;

            return matricula;
        }

        //Cargara los datos en el grid de la tabla matricula mediante un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLMatricula logica = new BLMatricula(Configuracion.getConnectionString);
            DataSet DSMatricula;

            try
            {
                DSMatricula = logica.ListarMatriculas(condicion, orden);
                grvMatriculas.DataSource = DSMatricula;
                grvMatriculas.DataMember = DSMatricula.Tables["Matricula"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para guardar el objeto en la base de datos, en caso de que el id este vacio lo inserta y si no lo modifica
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Genera las variables necesarias para utilizar
            EntidadMatricula matricula = new EntidadMatricula();
            BLMatricula logica = new BLMatricula(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtIdCursoAbierto.Text) |
                    !string.IsNullOrEmpty(txtIdEstudiante.Text) |
                    !string.IsNullOrEmpty(cboEstado.Text))
                {

                    matricula = GenerarEntidadMatricula();

                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        resultado = logica.Insertar(matricula);
                    }
                    else
                    {
                        resultado = logica.Modificar(matricula);
                    }
                    //Mensajes en base a los errores o incongruencias del programa
                    if (resultado > 0)
                    {
                        Limpiar();
                        MessageBox.Show("Operacion Correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Datos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo de carga del formulario 
        private void FrmMatriculas_Load(object sender, EventArgs e)
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
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Boton de cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnCerrar.Enabled = false;
            this.Close();
        }

        //Boton de limpiar el formulario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Metodo para cargar los datos en los campos del formulario
        private void CargarMatricula(int id)
        {
            EntidadMatricula matricula = new EntidadMatricula();
            BLMatricula traerMatricula = new BLMatricula(Configuracion.getConnectionString);
            try
            {
                matricula = traerMatricula.ObtenerMatricula(id);
                if (matricula != null)
                {
                    txtId.Text = matricula.IdEstudiante.ToString();
                    txtIdEstudiante.Text = matricula.IdEstudiante.ToString();
                    txtIdCursoAbierto.Text = matricula.Id_curso_abierto.ToString();
                    txtCosto.Text = matricula.Costo.ToString();
                    cboEstado.Text = matricula.Estado;

                    matriculaRegistrado = matricula;
                }
                else
                {
                    MessageBox.Show("La matricula no se encuentra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarListaDataSet();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Se llama al Cargar al darle doble click al elemento en el Grid
        private void grvMatriculas_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grvMatriculas.SelectedRows[0].Cells[0].Value;
                CargarMatricula(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
