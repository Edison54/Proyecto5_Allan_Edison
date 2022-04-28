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
    public partial class FrmProfesores : Form
    {
        //Creamos una variable global que llevara el nombre de matriculaRegistrado
        FrmBuscarProfe formularioBuscar;
        EntidadProfesor profesorRegistrado;

        //Se inicia el formulario
        public FrmProfesores()
        {
            InitializeComponent();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = DateTime.Now.ToString("t");
        }

        //Metodo de carga del formulario 
        private void FrmProfesores_Load(object sender, EventArgs e)
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

        //Metodo para generar una entidad de matricula en caso de estar ya generada la pasa la variable matriculaRegistrado
        private EntidadProfesor GenerarEntidadProfesor()
        {
            EntidadProfesor profesor;
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                profesor = profesorRegistrado;
            }
            else
            {
                profesor = new EntidadProfesor();
            }

            profesor.Cedula = txtCedula.Text;
            profesor.Nombre = txtNombre.Text;
            profesor.Correo = txtCorreo.Text;
            profesor.Direccion = txtDireccion.Text;
            profesor.Telefono = Convert.ToInt32(txtTelefono.Text);
            profesor.Sueldo = Convert.ToInt32(txtSueldo.Text);
            profesor.Idioma = cboIdioma.Text;

            return profesor;
        }

        //Metodo para guardar el objeto en la base de datos, en caso de que el id este vacio lo inserta y si no lo modifica
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadProfesor profesor = new EntidadProfesor();
            BLProfesor logica = new BLProfesor(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtCedula.Text) |
                    !string.IsNullOrEmpty(txtNombre.Text) |
                    !string.IsNullOrEmpty(txtCorreo.Text) |
                    !string.IsNullOrEmpty(txtDireccion.Text) |
                    !string.IsNullOrEmpty(txtTelefono.Text) |
                    !string.IsNullOrEmpty(txtSueldo.Text))
                {

                    profesor = GenerarEntidadProfesor();

                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        resultado = logica.Insertar(profesor);
                    }
                    else
                    {
                        resultado = logica.Modificar(profesor);
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

        //Cargara los datos en el grid de la tabla matricula mediante un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLProfesor logica = new BLProfesor(Configuracion.getConnectionString);
            DataSet DSProfesor;

            try
            {
                DSProfesor = logica.ListarProfesores(condicion, orden);
                grvProfesores.DataSource = DSProfesor;
                grvProfesores.DataMember = DSProfesor.Tables["Profesor"].TableName;
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
            txtSueldo.Text = string.Empty;
            cboIdioma.SelectedIndex = 0;
        }

        //Se llaman los metodos de eliominar 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadProfesor profesor;
            int resultado;
            BLProfesor logica = new BLProfesor(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    profesor = logica.ObtenerProfesor(int.Parse(txtId.Text));
                    if (profesor != null)
                    {
                        resultado = logica.Eliminar(profesor);
                        MessageBox.Show("Eliminado exitosamente", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El profesor no existe", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un profesor antes de eliminar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Se llama al formulario de busqueda 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new FrmBuscarProfe();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        //Metodo para cargar los datos en los campos del formulario
        private void CargarProfesor(int id)
        {
            EntidadProfesor profesor = new EntidadProfesor();
            BLProfesor traerProfesor = new BLProfesor(Configuracion.getConnectionString);
            try
            {
                profesor = traerProfesor.ObtenerProfesor(id);
                if (profesor != null)
                {
                    txtId.Text = profesor.IdProfesor.ToString();
                    txtCedula.Text = profesor.Cedula;
                    txtNombre.Text = profesor.Nombre;
                    txtCorreo.Text = profesor.Correo;
                    txtDireccion.Text = profesor.Direccion;
                    txtTelefono.Text = profesor.Telefono.ToString();
                    txtSueldo.Text = profesor.Sueldo.ToString();
                    if (profesor.Idioma == "Inglés")
                    {
                        cboIdioma.SelectedIndex = 0;
                    }
                    else if (profesor.Idioma == "Francés")
                    {
                        cboIdioma.SelectedIndex = 1;
                    }
                    else if (profesor.Idioma == "Alemán")
                    {
                        cboIdioma.SelectedIndex = 2;
                    }
                    else
                    {
                        cboIdioma.SelectedIndex = 3;
                    }

                    profesorRegistrado = profesor;
                }
                else
                {
                    MessageBox.Show("El profesor no se encuentra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarListaDataSet();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Metodo para cargar los datos en el grid con ayuda del cargar
        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idprofesor = (int)id;
                if (idprofesor != -1)
                {
                    CargarProfesor(idprofesor);
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

        //Boton de limpiar el formulario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Se llama al Cargar al darle doble click al elemento en el Gr
        private void grvProfesores_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grvProfesores.SelectedRows[0].Cells[0].Value;
                CargarProfesor(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
