
namespace C_Sharp2_AllanMadriz
{
    partial class FrmCursoAbierto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursoAbierto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grvCursos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_curso_abierto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTotalHoras = new System.Windows.Forms.ComboBox();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoraInicio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtHoraFin = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdProf = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtIdCurso = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCursos)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1082, 100);
            this.panel1.TabIndex = 48;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(73, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(149, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administración Cursos Abiertos";
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
            this.btnMinimize.Location = new System.Drawing.Point(998, 3);
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
            this.btnCerrar.Location = new System.Drawing.Point(1036, 3);
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
            // grvCursos
            // 
            this.grvCursos.AllowUserToAddRows = false;
            this.grvCursos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grvCursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvCursos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_curso_abierto,
            this.id_curso,
            this.idProfesor,
            this.horaInicio,
            this.horaFin,
            this.dia});
            this.grvCursos.DoubleBuffered = true;
            this.grvCursos.EnableHeadersVisualStyles = false;
            this.grvCursos.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.grvCursos.HeaderForeColor = System.Drawing.Color.White;
            this.grvCursos.Location = new System.Drawing.Point(330, 291);
            this.grvCursos.Name = "grvCursos";
            this.grvCursos.ReadOnly = true;
            this.grvCursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvCursos.Size = new System.Drawing.Size(584, 181);
            this.grvCursos.TabIndex = 63;
            this.grvCursos.DoubleClick += new System.EventHandler(this.grvCursos_DoubleClick);
            // 
            // id_curso_abierto
            // 
            this.id_curso_abierto.DataPropertyName = "id_curso_abierto";
            this.id_curso_abierto.HeaderText = "ID";
            this.id_curso_abierto.Name = "id_curso_abierto";
            this.id_curso_abierto.ReadOnly = true;
            this.id_curso_abierto.Width = 37;
            // 
            // id_curso
            // 
            this.id_curso.DataPropertyName = "id_curso";
            this.id_curso.HeaderText = "Curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            // 
            // idProfesor
            // 
            this.idProfesor.DataPropertyName = "id_profesor";
            this.idProfesor.HeaderText = "ID Profesor";
            this.idProfesor.Name = "idProfesor";
            this.idProfesor.ReadOnly = true;
            this.idProfesor.Visible = false;
            this.idProfesor.Width = 250;
            // 
            // horaInicio
            // 
            this.horaInicio.DataPropertyName = "hora_inicio";
            this.horaInicio.HeaderText = "Hora de Inicio";
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.ReadOnly = true;
            this.horaInicio.Width = 150;
            // 
            // horaFin
            // 
            this.horaFin.DataPropertyName = "hora_fin";
            this.horaFin.HeaderText = "Hora de Cierre";
            this.horaFin.Name = "horaFin";
            this.horaFin.ReadOnly = true;
            this.horaFin.Width = 150;
            // 
            // dia
            // 
            this.dia.DataPropertyName = "dia";
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            this.dia.Width = 105;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtId.BorderColor = System.Drawing.Color.Navy;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Navy;
            this.txtId.Location = new System.Drawing.Point(246, 140);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(106, 25);
            this.txtId.TabIndex = 51;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(381, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "ID Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(256, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Id Abierto";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 90);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1080, 10);
            this.bunifuSeparator1.TabIndex = 50;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 402);
            this.panel2.TabIndex = 49;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.BorderRadius = 7;
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = null;
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 90D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(12, 242);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.LightSteelBlue;
            this.btnNuevo.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(177, 52);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Textcolor = System.Drawing.Color.MidnightBlue;
            this.btnNuevo.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.BorderRadius = 7;
            this.btnBuscar.ButtonText = "Buscar Curso";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscar.Iconimage = null;
            this.btnBuscar.Iconimage_right = null;
            this.btnBuscar.Iconimage_right_Selected = null;
            this.btnBuscar.Iconimage_Selected = null;
            this.btnBuscar.IconMarginLeft = 0;
            this.btnBuscar.IconMarginRight = 0;
            this.btnBuscar.IconRightVisible = true;
            this.btnBuscar.IconRightZoom = 0D;
            this.btnBuscar.IconVisible = true;
            this.btnBuscar.IconZoom = 90D;
            this.btnBuscar.IsTab = false;
            this.btnBuscar.Location = new System.Drawing.Point(12, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.OnHovercolor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverTextColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.selected = false;
            this.btnBuscar.Size = new System.Drawing.Size(177, 52);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Curso";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Textcolor = System.Drawing.Color.White;
            this.btnBuscar.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.BorderRadius = 7;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = null;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 90D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(12, 96);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(177, 52);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.BorderRadius = 7;
            this.btnGuardar.ButtonText = "Agregar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = null;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(12, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverTextColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(178, 52);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(604, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "Horas por dia";
            // 
            // cboTotalHoras
            // 
            this.cboTotalHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTotalHoras.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTotalHoras.FormattingEnabled = true;
            this.cboTotalHoras.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboTotalHoras.Location = new System.Drawing.Point(735, 137);
            this.cboTotalHoras.Name = "cboTotalHoras";
            this.cboTotalHoras.Size = new System.Drawing.Size(196, 25);
            this.cboTotalHoras.TabIndex = 71;
            this.cboTotalHoras.TextChanged += new System.EventHandler(this.cboTotalHoras_TextChanged);
            // 
            // cboDia
            // 
            this.cboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDia.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.cboDia.Location = new System.Drawing.Point(795, 206);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(202, 25);
            this.cboDia.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(703, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 73;
            this.label9.Text = "Dia Clase";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(249, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 74;
            this.label10.Text = "Horas Inicio";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHoraInicio.BorderColor = System.Drawing.Color.Navy;
            this.txtHoraInicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraInicio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInicio.ForeColor = System.Drawing.Color.Navy;
            this.txtHoraInicio.Location = new System.Drawing.Point(352, 208);
            this.txtHoraInicio.Multiline = true;
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(94, 25);
            this.txtHoraInicio.TabIndex = 75;
            this.txtHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraInicio.TextChanged += new System.EventHandler(this.txtHoraInicio_TextChanged);
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHoraFin.BorderColor = System.Drawing.Color.Navy;
            this.txtHoraFin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraFin.Enabled = false;
            this.txtHoraFin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraFin.ForeColor = System.Drawing.Color.Navy;
            this.txtHoraFin.Location = new System.Drawing.Point(563, 208);
            this.txtHoraFin.Multiline = true;
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(94, 25);
            this.txtHoraFin.TabIndex = 77;
            this.txtHoraFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(460, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 76;
            this.label11.Text = "Horas Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(485, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "ID Profesor";
            // 
            // txtIdProf
            // 
            this.txtIdProf.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIdProf.BorderColor = System.Drawing.Color.Navy;
            this.txtIdProf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProf.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProf.ForeColor = System.Drawing.Color.Navy;
            this.txtIdProf.Location = new System.Drawing.Point(485, 139);
            this.txtIdProf.Multiline = true;
            this.txtIdProf.Name = "txtIdProf";
            this.txtIdProf.Size = new System.Drawing.Size(94, 25);
            this.txtIdProf.TabIndex = 55;
            this.txtIdProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIdCurso.BorderColor = System.Drawing.Color.Navy;
            this.txtIdCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCurso.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCurso.ForeColor = System.Drawing.Color.Navy;
            this.txtIdCurso.Location = new System.Drawing.Point(367, 139);
            this.txtIdCurso.Multiline = true;
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(106, 25);
            this.txtIdCurso.TabIndex = 78;
            this.txtIdCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCursoAbierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 502);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboDia);
            this.Controls.Add(this.cboTotalHoras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grvCursos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCursoAbierto";
            this.Text = "FrmCurso";
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCursos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grvCursos;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrar;
        private System.Windows.Forms.ComboBox cboTotalHoras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboDia;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtHoraFin;
        private System.Windows.Forms.Label label11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtHoraInicio;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIdProf;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso_abierto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
    }
}