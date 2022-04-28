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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        //Cada boton llama un Formulario distinto

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frm = new FrmEstudiantes();
            frm.Show();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FrmProfesores frm = new FrmProfesores();
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProgramas_Click(object sender, EventArgs e)
        {
            FrmProgramas frm = new FrmProgramas();
            frm.Show();
        }

        private void btnAdministrativos_Click(object sender, EventArgs e)
        {
            FrmAdministrativo frm = new FrmAdministrativo();
            frm.Show();
        }

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            FrmMatriculas frm = new FrmMatriculas();
            frm.Show();
        }
    }
}
