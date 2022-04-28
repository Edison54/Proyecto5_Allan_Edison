
namespace C_Sharp2_AllanMadriz
{
    partial class FrmMatriculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatriculas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grvMatriculas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso_abierto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEstudiante = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCursoAbierto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCosto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMatriculas)).BeginInit();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 100);
            this.panel1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administración Matriculas";
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
            this.btnMinimize.Location = new System.Drawing.Point(670, 12);
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
            this.btnCerrar.Location = new System.Drawing.Point(708, 12);
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
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.ForeColor = System.Drawing.Color.Navy;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "CANCELADA",
            "PENDIENTE"});
            this.cboEstado.Location = new System.Drawing.Point(486, 209);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(171, 25);
            this.cboEstado.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(540, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 94;
            this.label10.Text = "Estado";
            // 
            // grvMatriculas
            // 
            this.grvMatriculas.AllowUserToAddRows = false;
            this.grvMatriculas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grvMatriculas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvMatriculas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grvMatriculas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvMatriculas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvMatriculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_matricula,
            this.id_estudiante,
            this.id_curso_abierto,
            this.costo,
            this.estado});
            this.grvMatriculas.DoubleBuffered = true;
            this.grvMatriculas.EnableHeadersVisualStyles = false;
            this.grvMatriculas.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.grvMatriculas.HeaderForeColor = System.Drawing.Color.White;
            this.grvMatriculas.Location = new System.Drawing.Point(220, 249);
            this.grvMatriculas.Name = "grvMatriculas";
            this.grvMatriculas.ReadOnly = true;
            this.grvMatriculas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvMatriculas.Size = new System.Drawing.Size(506, 181);
            this.grvMatriculas.TabIndex = 92;
            this.grvMatriculas.DoubleClick += new System.EventHandler(this.grvMatriculas_DoubleClick);
            // 
            // id_matricula
            // 
            this.id_matricula.DataPropertyName = "id_matricula";
            this.id_matricula.HeaderText = "ID";
            this.id_matricula.Name = "id_matricula";
            this.id_matricula.ReadOnly = true;
            this.id_matricula.Width = 40;
            // 
            // id_estudiante
            // 
            this.id_estudiante.DataPropertyName = "id_estudiante";
            this.id_estudiante.HeaderText = "Estudiante";
            this.id_estudiante.Name = "id_estudiante";
            this.id_estudiante.ReadOnly = true;
            // 
            // id_curso_abierto
            // 
            this.id_curso_abierto.DataPropertyName = "id_curso_abierto";
            this.id_curso_abierto.HeaderText = "Curso Abierto";
            this.id_curso_abierto.Name = "id_curso_abierto";
            this.id_curso_abierto.ReadOnly = true;
            this.id_curso_abierto.Width = 125;
            // 
            // costo
            // 
            this.costo.DataPropertyName = "costo";
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
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
            this.txtId.Location = new System.Drawing.Point(248, 148);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(106, 25);
            this.txtId.TabIndex = 79;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(382, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 82;
            this.label3.Text = "Id Estudiante";
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIdEstudiante.BorderColor = System.Drawing.Color.Navy;
            this.txtIdEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEstudiante.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstudiante.ForeColor = System.Drawing.Color.Navy;
            this.txtIdEstudiante.Location = new System.Drawing.Point(381, 148);
            this.txtIdEstudiante.Multiline = true;
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.Size = new System.Drawing.Size(115, 25);
            this.txtIdEstudiante.TabIndex = 81;
            this.txtIdEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(247, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Id Matricula";
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
            this.bunifuSeparator1.TabIndex = 78;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 368);
            this.panel2.TabIndex = 77;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.BorderRadius = 7;
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnNuevo.Location = new System.Drawing.Point(11, 163);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.OnHovercolor = System.Drawing.Color.White;
            this.btnNuevo.OnHoverTextColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(178, 52);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnEliminar.Textcolor = System.Drawing.Color.Black;
            this.btnEliminar.TextFont = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(519, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 97;
            this.label4.Text = "Id Curso Abierto";
            // 
            // txtIdCursoAbierto
            // 
            this.txtIdCursoAbierto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtIdCursoAbierto.BorderColor = System.Drawing.Color.Navy;
            this.txtIdCursoAbierto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCursoAbierto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCursoAbierto.ForeColor = System.Drawing.Color.Navy;
            this.txtIdCursoAbierto.Location = new System.Drawing.Point(518, 148);
            this.txtIdCursoAbierto.Multiline = true;
            this.txtIdCursoAbierto.Name = "txtIdCursoAbierto";
            this.txtIdCursoAbierto.Size = new System.Drawing.Size(139, 25);
            this.txtIdCursoAbierto.TabIndex = 96;
            this.txtIdCursoAbierto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(211, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 19);
            this.label5.TabIndex = 99;
            this.label5.Text = "Costo(Generado por programa)";
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCosto.BorderColor = System.Drawing.Color.Navy;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.Navy;
            this.txtCosto.Location = new System.Drawing.Point(269, 209);
            this.txtCosto.Multiline = true;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(139, 25);
            this.txtCosto.TabIndex = 98;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 468);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdCursoAbierto);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grvMatriculas);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdEstudiante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMatriculas";
            this.Text = "FrmMatriculas";
            this.Load += new System.EventHandler(this.FrmMatriculas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvMatriculas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIdCursoAbierto;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grvMatriculas;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtId;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtIdEstudiante;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrar;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso_abierto;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
    }
}