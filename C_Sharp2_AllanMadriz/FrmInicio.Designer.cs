
namespace C_Sharp2_AllanMadriz
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMatriculas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdministrativos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProgramas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProfesores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEstudiantes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(116, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(194, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interactivo Instituto de Idiomas";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Activecolor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.ButtonText = "";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DisabledColor = System.Drawing.Color.Gray;
            this.btnMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMinimize.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Iconimage")));
            this.btnMinimize.Iconimage_right = null;
            this.btnMinimize.Iconimage_right_Selected = null;
            this.btnMinimize.Iconimage_Selected = null;
            this.btnMinimize.IconMarginLeft = 0;
            this.btnMinimize.IconMarginRight = 0;
            this.btnMinimize.IconRightVisible = true;
            this.btnMinimize.IconRightZoom = 0D;
            this.btnMinimize.IconVisible = true;
            this.btnMinimize.IconZoom = 30D;
            this.btnMinimize.IsTab = false;
            this.btnMinimize.Location = new System.Drawing.Point(718, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMinimize.OnHovercolor = System.Drawing.Color.LightBlue;
            this.btnMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMinimize.selected = false;
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Textcolor = System.Drawing.Color.White;
            this.btnMinimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Activecolor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.BorderRadius = 0;
            this.btnCerrar.ButtonText = "";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Iconimage")));
            this.btnCerrar.Iconimage_right = null;
            this.btnCerrar.Iconimage_right_Selected = null;
            this.btnCerrar.Iconimage_Selected = null;
            this.btnCerrar.IconMarginLeft = 0;
            this.btnCerrar.IconMarginRight = 0;
            this.btnCerrar.IconRightVisible = true;
            this.btnCerrar.IconRightZoom = 0D;
            this.btnCerrar.IconVisible = true;
            this.btnCerrar.IconZoom = 30D;
            this.btnCerrar.IsTab = false;
            this.btnCerrar.Location = new System.Drawing.Point(756, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCerrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrar.selected = false;
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Textcolor = System.Drawing.Color.White;
            this.btnCerrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 90);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(800, 10);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnMatriculas);
            this.panel2.Controls.Add(this.btnAdministrativos);
            this.panel2.Controls.Add(this.btnProgramas);
            this.panel2.Controls.Add(this.btnProfesores);
            this.panel2.Controls.Add(this.btnEstudiantes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 394);
            this.panel2.TabIndex = 8;
            // 
            // btnMatriculas
            // 
            this.btnMatriculas.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnMatriculas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMatriculas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMatriculas.BorderRadius = 7;
            this.btnMatriculas.ButtonText = "Matriculas";
            this.btnMatriculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatriculas.DisabledColor = System.Drawing.Color.Gray;
            this.btnMatriculas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnMatriculas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMatriculas.Iconimage = null;
            this.btnMatriculas.Iconimage_right = null;
            this.btnMatriculas.Iconimage_right_Selected = null;
            this.btnMatriculas.Iconimage_Selected = null;
            this.btnMatriculas.IconMarginLeft = 0;
            this.btnMatriculas.IconMarginRight = 0;
            this.btnMatriculas.IconRightVisible = true;
            this.btnMatriculas.IconRightZoom = 0D;
            this.btnMatriculas.IconVisible = true;
            this.btnMatriculas.IconZoom = 90D;
            this.btnMatriculas.IsTab = false;
            this.btnMatriculas.Location = new System.Drawing.Point(12, 239);
            this.btnMatriculas.Name = "btnMatriculas";
            this.btnMatriculas.Normalcolor = System.Drawing.Color.LightSteelBlue;
            this.btnMatriculas.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnMatriculas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMatriculas.selected = false;
            this.btnMatriculas.Size = new System.Drawing.Size(177, 52);
            this.btnMatriculas.TabIndex = 5;
            this.btnMatriculas.Text = "Matriculas";
            this.btnMatriculas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMatriculas.Textcolor = System.Drawing.Color.MidnightBlue;
            this.btnMatriculas.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriculas.Click += new System.EventHandler(this.btnMatriculas_Click);
            // 
            // btnAdministrativos
            // 
            this.btnAdministrativos.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnAdministrativos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdministrativos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdministrativos.BorderRadius = 7;
            this.btnAdministrativos.ButtonText = "Administrativos";
            this.btnAdministrativos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrativos.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdministrativos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdministrativos.Iconimage = null;
            this.btnAdministrativos.Iconimage_right = null;
            this.btnAdministrativos.Iconimage_right_Selected = null;
            this.btnAdministrativos.Iconimage_Selected = null;
            this.btnAdministrativos.IconMarginLeft = 0;
            this.btnAdministrativos.IconMarginRight = 0;
            this.btnAdministrativos.IconRightVisible = true;
            this.btnAdministrativos.IconRightZoom = 0D;
            this.btnAdministrativos.IconVisible = true;
            this.btnAdministrativos.IconZoom = 90D;
            this.btnAdministrativos.IsTab = false;
            this.btnAdministrativos.Location = new System.Drawing.Point(13, 309);
            this.btnAdministrativos.Name = "btnAdministrativos";
            this.btnAdministrativos.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnAdministrativos.OnHovercolor = System.Drawing.Color.White;
            this.btnAdministrativos.OnHoverTextColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdministrativos.selected = false;
            this.btnAdministrativos.Size = new System.Drawing.Size(177, 52);
            this.btnAdministrativos.TabIndex = 4;
            this.btnAdministrativos.Text = "Administrativos";
            this.btnAdministrativos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdministrativos.Textcolor = System.Drawing.Color.White;
            this.btnAdministrativos.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrativos.Click += new System.EventHandler(this.btnAdministrativos_Click);
            // 
            // btnProgramas
            // 
            this.btnProgramas.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnProgramas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnProgramas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProgramas.BorderRadius = 7;
            this.btnProgramas.ButtonText = "Programas";
            this.btnProgramas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgramas.DisabledColor = System.Drawing.Color.Gray;
            this.btnProgramas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProgramas.Iconimage = null;
            this.btnProgramas.Iconimage_right = null;
            this.btnProgramas.Iconimage_right_Selected = null;
            this.btnProgramas.Iconimage_Selected = null;
            this.btnProgramas.IconMarginLeft = 0;
            this.btnProgramas.IconMarginRight = 0;
            this.btnProgramas.IconRightVisible = true;
            this.btnProgramas.IconRightZoom = 0D;
            this.btnProgramas.IconVisible = true;
            this.btnProgramas.IconZoom = 90D;
            this.btnProgramas.IsTab = false;
            this.btnProgramas.Location = new System.Drawing.Point(12, 170);
            this.btnProgramas.Name = "btnProgramas";
            this.btnProgramas.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnProgramas.OnHovercolor = System.Drawing.Color.White;
            this.btnProgramas.OnHoverTextColor = System.Drawing.SystemColors.HotTrack;
            this.btnProgramas.selected = false;
            this.btnProgramas.Size = new System.Drawing.Size(177, 52);
            this.btnProgramas.TabIndex = 2;
            this.btnProgramas.Text = "Programas";
            this.btnProgramas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProgramas.Textcolor = System.Drawing.Color.White;
            this.btnProgramas.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramas.Click += new System.EventHandler(this.btnProgramas_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnProfesores.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProfesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfesores.BorderRadius = 7;
            this.btnProfesores.ButtonText = "Profesores";
            this.btnProfesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesores.DisabledColor = System.Drawing.Color.Gray;
            this.btnProfesores.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnProfesores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfesores.Iconimage = null;
            this.btnProfesores.Iconimage_right = null;
            this.btnProfesores.Iconimage_right_Selected = null;
            this.btnProfesores.Iconimage_Selected = null;
            this.btnProfesores.IconMarginLeft = 0;
            this.btnProfesores.IconMarginRight = 0;
            this.btnProfesores.IconRightVisible = true;
            this.btnProfesores.IconRightZoom = 0D;
            this.btnProfesores.IconVisible = true;
            this.btnProfesores.IconZoom = 90D;
            this.btnProfesores.IsTab = false;
            this.btnProfesores.Location = new System.Drawing.Point(12, 96);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Normalcolor = System.Drawing.Color.LightSteelBlue;
            this.btnProfesores.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnProfesores.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProfesores.selected = false;
            this.btnProfesores.Size = new System.Drawing.Size(177, 52);
            this.btnProfesores.TabIndex = 1;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfesores.Textcolor = System.Drawing.Color.MidnightBlue;
            this.btnProfesores.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnEstudiantes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEstudiantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEstudiantes.BorderRadius = 7;
            this.btnEstudiantes.ButtonText = "Estudiantes";
            this.btnEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstudiantes.DisabledColor = System.Drawing.Color.Gray;
            this.btnEstudiantes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.Iconimage = null;
            this.btnEstudiantes.Iconimage_right = null;
            this.btnEstudiantes.Iconimage_right_Selected = null;
            this.btnEstudiantes.Iconimage_Selected = null;
            this.btnEstudiantes.IconMarginLeft = 0;
            this.btnEstudiantes.IconMarginRight = 0;
            this.btnEstudiantes.IconRightVisible = true;
            this.btnEstudiantes.IconRightZoom = 0D;
            this.btnEstudiantes.IconVisible = true;
            this.btnEstudiantes.IconZoom = 90D;
            this.btnEstudiantes.IsTab = false;
            this.btnEstudiantes.Location = new System.Drawing.Point(12, 21);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnEstudiantes.OnHovercolor = System.Drawing.Color.White;
            this.btnEstudiantes.OnHoverTextColor = System.Drawing.SystemColors.HotTrack;
            this.btnEstudiantes.selected = false;
            this.btnEstudiantes.Size = new System.Drawing.Size(178, 52);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEstudiantes.Textcolor = System.Drawing.Color.White;
            this.btnEstudiantes.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnProgramas;
        private Bunifu.Framework.UI.BunifuFlatButton btnProfesores;
        private Bunifu.Framework.UI.BunifuFlatButton btnEstudiantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdministrativos;
        private Bunifu.Framework.UI.BunifuFlatButton btnMatriculas;
    }
}

