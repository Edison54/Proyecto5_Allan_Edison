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
    public partial class FrmEstudiantes : Form
    {
        //Creamos una variable global que llevara el nombre de matriculaRegistrado
        FrmBuscarEstudiante formularioBuscar;
        EntidadEstudiante estudianteRegistrado;

        //Se inicia el formulario
        public FrmEstudiantes()
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

        //Metodo de carga del formulario 
        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString("t");
        }

        //Metodo para generar una entidad de matricula en caso de estar ya generada la pasa la variable matriculaRegistrado
        private EntidadEstudiante GenerarEntidadEstudiante()
        {
            EntidadEstudiante estudiante;
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                estudiante = estudianteRegistrado;
            }
            else
            {
                estudiante = new EntidadEstudiante();
            }

            estudiante.Cedula = txtCedula.Text;
            estudiante.Nombre = txtNombre.Text;
            estudiante.Correo = txtCorreo.Text;
            estudiante.Direccion = txtDireccion.Text;
            estudiante.Telefono = Convert.ToInt32(txtTelefono.Text);

            return estudiante;
        }

        //Metodo para guardar el objeto en la base de datos, en caso de que el id este vacio lo inserta y si no lo modifica
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();
            BLEstudiante logica = new BLEstudiante(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtCedula.Text) |
                    !string.IsNullOrEmpty(txtNombre.Text) |
                    !string.IsNullOrEmpty(txtCorreo.Text) |
                    !string.IsNullOrEmpty(txtDireccion.Text) |
                    !string.IsNullOrEmpty(txtTelefono.Text)){

                    estudiante = GenerarEntidadEstudiante();

                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        resultado = logica.Insertar(estudiante);
                    }
                    else
                    {
                        resultado = logica.Modificar(estudiante);
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

        //Metodo para limpiar todos los campos del formulario
        private void Limpiar()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCedula.Text = string.Empty;
        }

        //Boton de limpiar el formulario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        //Se llaman los metodos de eliominar 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadEstudiante estudiante;
            int resultado;
            BLEstudiante logica = new BLEstudiante(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    estudiante = logica.ObtenerEstudiante(int.Parse(txtId.Text));
                    if (estudiante != null)
                    {
                        resultado = logica.EliminarConSP(estudiante);
                        MessageBox.Show("Eliminado exitosamente", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El Estudiante no existe", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un estudiante antes de eliminar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para cargar los datos en los campos del formulario
        private void CargarEstudiante(int id)
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();
            BLEstudiante traerEstudiante = new BLEstudiante(Configuracion.getConnectionString);
            try
            {
                estudiante = traerEstudiante.ObtenerEstudiante(id);
                if (estudiante != null)
                {
                    txtId.Text = estudiante.IdEstudiante.ToString();
                    txtCedula.Text = estudiante.Cedula;
                    txtNombre.Text = estudiante.Nombre;
                    txtCorreo.Text = estudiante.Correo;
                    txtDireccion.Text = estudiante.Direccion;
                    txtTelefono.Text = estudiante.Telefono.ToString();

                    estudianteRegistrado = estudiante;
                }
                else
                {
                    MessageBox.Show("El estudiante no se encuentra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarListaDataSet();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Se llama al formulario de busqueda 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new FrmBuscarEstudiante();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        //Metodo para cargar los datos en el grid con ayuda del cargar
        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idestudiante = (int)id;
                if (idestudiante != -1)
                {
                    CargarEstudiante(idestudiante);
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

        //Se llama al Cargar al darle doble click al elemento en el Grid
        private void grvEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grvEstudiantes.SelectedRows[0].Cells[0].Value;
                CargarEstudiante(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
