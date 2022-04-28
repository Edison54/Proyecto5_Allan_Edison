using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp2_AllanMadriz
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BLUsuario logica = new BLUsuario(Configuracion.getConnectionString);
            try
            {
                string user = txtNombreUsuario.Text;
                string pass = txtPassword.Text;
                if (user != "" && pass != "")
                {
                    if (logica.Loguear(user, pass) != null)
                    {
                        MessageBox.Show(logica.Mensaje);
                        FrmInicio frm = new FrmInicio();
                        frm.Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(logica.Mensaje);
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }  

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
