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
    public partial class FrmCursoAbierto : Form
    {
        //Creamos una variable global que llevara el nombre de matriculaRegist
        FrmBuscarCurso formularioBuscar;
        EntidadCursoAbierto cursoRegistrado;

        //Se inicia el formulario
        public FrmCursoAbierto()
        {
            InitializeComponent();
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

        //Metodo para generar una entidad de matricula en caso de estar ya generada la pasa la variable matriculaRegistrado
        private EntidadCursoAbierto GenerarEntidadCurso()
        {
            EntidadCursoAbierto curso;
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                curso = cursoRegistrado;
            }
            else
            {
                curso = new EntidadCursoAbierto();
            }

            curso.IdCurso = Convert.ToInt32(txtIdCurso.Text);
            curso.IdProfesor = Convert.ToInt32(txtIdProf.Text);
            curso.HoraInicio = Convert.ToInt32(txtHoraInicio.Text);
            curso.HoraFin = Convert.ToInt32(txtHoraFin.Text);
            curso.Dia = cboDia.Text;

            return curso;
        }

        //Metodo para guardar el objeto en la base de datos, en caso de que el id este vacio lo inserta y si no lo modifica
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadCursoAbierto curso = new EntidadCursoAbierto();
            BLCursoAbierto logica = new BLCursoAbierto(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtIdProf.Text) ||
                    !string.IsNullOrEmpty(cboTotalHoras.Text) ||
                    !string.IsNullOrEmpty(cboDia.Text) ||
                    !string.IsNullOrEmpty(txtHoraInicio.Text) ||
                    !string.IsNullOrEmpty(txtHoraFin.Text) || 
                    !string.IsNullOrEmpty(cboDia.Text))
                {

                    curso = GenerarEntidadCurso();

                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        resultado = logica.Insertar(curso);
                    }
                    else
                    {
                        resultado = logica.Modificar(curso);
                    }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadCursoAbierto cursoAbierto;
            int resultado;
            BLCursoAbierto logica = new BLCursoAbierto(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    cursoAbierto = logica.ObtenerCurso(int.Parse(txtId.Text));
                    if (cursoAbierto != null)
                    {
                        resultado = logica.Eliminar(cursoAbierto);
                        MessageBox.Show("Eliminado exitosamente", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El curso no existe o no se ha abierto", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un curso antes de eliminar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new FrmBuscarCurso();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        //Boton de limpiar el formulario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idCurso = (int)id;
                if (idCurso != -1)
                {
                    CargarCurso(idCurso);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para cargar los datos en los campos del formulario
        private void CargarCurso(int id)
        {
            EntidadCursoAbierto curso = new EntidadCursoAbierto();
            BLCursoAbierto traerCurso = new BLCursoAbierto(Configuracion.getConnectionString);
            try
            {
                curso = traerCurso.ObtenerCurso(id);
                if (curso != null)
                {
                    txtId.Text = curso.IdCursoAbierto.ToString();
                    txtIdCurso.Text = curso.IdCurso.ToString();
                    txtIdProf.Text = curso.IdProfesor.ToString();
                    txtHoraInicio.Text = curso.HoraInicio.ToString();
                    txtHoraFin.Text = curso.HoraFin.ToString();
                    cboDia.Text = curso.Dia.ToString();
                    cursoRegistrado = curso;
                }
                else
                {
                    MessageBox.Show("El curso no se encuentra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarListaDataSet();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        //Metodo para limpiar todos los campos del formulario
        private void Limpiar()
        {
            txtId.Text = string.Empty;
            txtIdProf.Text = string.Empty;
            txtIdCurso.Text = string.Empty;
            cboTotalHoras.SelectedIndex = -1;
            txtHoraInicio.Text = string.Empty;
            txtHoraFin.Text = string.Empty;
            cboDia.SelectedIndex = -1;
        }

        //Se llama al Cargar al darle doble click al elemento en el Grid
        private void grvCursos_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grvCursos.SelectedRows[0].Cells[0].Value;
                CargarCurso(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Metodo de carga del formulario 
        private void FrmCurso_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
                calcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Calculamos el total de horas en base a las seleccionada de inicio
        private void calcularTotal()
        {
            if (!string.IsNullOrEmpty(txtHoraInicio.Text) &
                !string.IsNullOrEmpty(cboTotalHoras.Text))
            {
                txtHoraFin.Text =
                   (Convert.ToInt32(txtHoraInicio.Text) +
                    Convert.ToInt32(cboTotalHoras.Text)).ToString();
            }
        }

        //Llamamos el metodo calcularTotal
        private void cboTotalHoras_TextChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        //Llamamos el metodo calcularTotal
        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }
    }
}
