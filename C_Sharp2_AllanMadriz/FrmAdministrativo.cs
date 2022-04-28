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
    public partial class FrmAdministrativo : Form
    {
        //Para todos los formularios se utiliza el mismo procedimiento, por lo cual no se hara una documentacion completa de todo
        //Unicamente se explicara mas a detalle en este formulario, aparte de que todo ha sido analizado anteriormente en clase

        //Creamos una variable global que llevara el nombre de adminRegistrado
        EntidadAdministrativo adminRegistrado;

        //Se inicia el formulario
        public FrmAdministrativo()
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

        //Metodo para generar una entidad de matricula en caso de estar ya generada la pasa la variable adminRegistrado
        private EntidadAdministrativo GenerarEntidadAdmin()
        {
            //Creamos una variable de tipo Entidad
            EntidadAdministrativo admin;
            //Revisamos si el campo de ID esta vacio o no, en caso de estar vacio se crea nueva instancia si no se iguala a la variable global
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                admin = adminRegistrado;
            }
            else
            {
                admin = new EntidadAdministrativo();
            }

            //A los atributos de la entidad le colocamos los datos que se encuentren en los campos
            admin.IdPrograma = Convert.ToInt32(txtIdPrograma.Text);
            admin.Nombre = txtNombre.Text;
            admin.Correo = txtCorreo.Text;
            admin.Direccion = txtDireccion.Text;
            admin.Telefono = Convert.ToInt32(txtTelefono.Text);
            admin.Cargo = cboCargo.Text;
            admin.Departamento = cboDepartamento.Text;

            return admin;
        }

        //Cargara los datos en el grid de la tabla Administrativos mediante un DataSet
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            //Se crean las variables necesarias de la capa logica de negocio
            BLAdministrativo logica = new BLAdministrativo(Configuracion.getConnectionString);
            DataSet DSAdmin;
            //Con ayuda del DataSet cargamos los datos de la tabla en el Grid view
            try
            {
                DSAdmin = logica.ListarAdministrativos(condicion, orden);
                grvAdmins.DataSource = DSAdmin;
                grvAdmins.DataMember = DSAdmin.Tables["Administrativo"].TableName;
            }
            catch (Exception ex) //En caso de algun error nos va devolver el mensaje correspondiente
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para cargar los datos en los campos del formulario
        private void CargarAdmin(int id)
        {
            //Creamos las variables necesarias de la capa entidad y logica de negocios
            EntidadAdministrativo admin = new EntidadAdministrativo();
            BLAdministrativo traerAdmin = new BLAdministrativo(Configuracion.getConnectionString);
            //Nos traemos el dato en base al ID que se le pasa 
            try
            {
                admin = traerAdmin.ObtenerAdmin(id);
                if (admin != null)
                {
                    //Llenamos los campos de texto del formulario con los datos recuperados
                    txtId.Text = admin.IdAdmin.ToString();
                    txtIdPrograma.Text = admin.IdPrograma.ToString();
                    txtNombre.Text = admin.Nombre;
                    txtCorreo.Text = admin.Correo;
                    txtDireccion.Text = admin.Direccion;
                    txtTelefono.Text = admin.Telefono.ToString();
                    cboCargo.Text = admin.Cargo;
                    cboDepartamento.Text = admin.Departamento;

                    adminRegistrado = admin;
                }
                else
                {
                    //En caso de que no se encuentre se avisa del caso
                    MessageBox.Show("El admin no se encuentra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarListaDataSet();
                }

            }
            catch (Exception ex) //Si se ocasiona algun error
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Metodo para limpiar todos los campos del formulario
        private void Limpiar()
        {
            //Vaciamos todos los campos del formulario actual
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            cboCargo.SelectedIndex = -1;
            cboDepartamento.SelectedIndex = -1;
        }

        //Metodo para guardar el objeto en la base de datos, en caso de que el id este vacio lo inserta y si no lo modifica
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creamos las variables necesarias de las capas entidad y logica de negocio 
            EntidadAdministrativo administrativo = new EntidadAdministrativo();
            BLAdministrativo logica = new BLAdministrativo(Configuracion.getConnectionString);
            int resultado;

            try
            {
                //Revisamos que los campos no se encuentren vacios
                if (!string.IsNullOrEmpty(cboCargo.Text) |
                    !string.IsNullOrEmpty(cboDepartamento.Text) |
                    !string.IsNullOrEmpty(txtIdPrograma.Text) |
                    !string.IsNullOrEmpty(txtNombre.Text) |
                    !string.IsNullOrEmpty(txtCorreo.Text) |
                    !string.IsNullOrEmpty(txtDireccion.Text) |
                    !string.IsNullOrEmpty(txtTelefono.Text))
                {
                    //Llamamos a generar entidad 
                    administrativo = GenerarEntidadAdmin();

                    //En caso de que el campo ID este vacio se inserta el registro, de lo contrario 
                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        resultado = logica.Insertar(administrativo);
                    }
                    else
                    {
                        resultado = logica.Modificar(administrativo);
                    }
                    //Segun la respuesta se muestra el mensaje equivalente
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

        //Metodo para eliminar los datos, siempre y cuando exista y se seleccione el ID primero para tener una referencia
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Se crean las variables a utilizar
            EntidadAdministrativo administrativo;
            int resultado;
            BLAdministrativo logica = new BLAdministrativo(Configuracion.getConnectionString);
            try
            {
                //Revisamos que no tengan algun problema y se llama al metodo, si no tirara el mensaje correspondiente
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    //Revisamos que no sea null para proceder a eliminar el elemento en caso contrario tiramos un mensaje
                    administrativo = logica.ObtenerAdmin(int.Parse(txtId.Text));
                    if (administrativo != null)
                    {
                        resultado = logica.EliminarConSP(administrativo);
                        MessageBox.Show("Eliminado exitosamente", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Limpiar();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El administrativo no existe", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        Limpiar();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un administrativo antes de eliminar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) //En caso de error se tira el mensaje que va junto a el
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton de limpiar el formulario
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Metodo de carga del formulario 
        private void FrmAdministrativo_Load(object sender, EventArgs e)
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

        //Se llama al Cargar al darle doble click al elemento en el Grid
        private void grvAdmins_DoubleClick(object sender, EventArgs e)
        {
            //Colocamos los datos en los campos del formulario
            int id = 0;
            try
            {
                id = (int)grvAdmins.SelectedRows[0].Cells[0].Value;
                CargarAdmin(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdPrograma.SelectedIndex = cboDepartamento.SelectedIndex;
        }

        private void txtIdPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDepartamento.SelectedIndex = txtIdPrograma.SelectedIndex;
        }
    }
}
