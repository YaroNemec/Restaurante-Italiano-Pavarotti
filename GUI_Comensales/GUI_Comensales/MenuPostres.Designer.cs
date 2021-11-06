
namespace GUI_Comensales
{
    partial class MenuPostres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuplatos = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menubebidas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.principal = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_postres = new System.Windows.Forms.DataGridView();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.siguiente_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.anadidos_dg = new System.Windows.Forms.DataGridView();
            this.platillo_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anadir_postre = new System.Windows.Forms.Button();
            this.quitar_postre = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.postre = new System.Windows.Forms.Label();
            this.precio_postre = new System.Windows.Forms.Label();
            this.cant_platos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_postres)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anadidos_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1486, 82);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.menuplatos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(886, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 82);
            this.panel5.TabIndex = 11;
            // 
            // menuplatos
            // 
            this.menuplatos.AutoSize = true;
            this.menuplatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuplatos.ForeColor = System.Drawing.Color.Yellow;
            this.menuplatos.Location = new System.Drawing.Point(56, 36);
            this.menuplatos.Name = "menuplatos";
            this.menuplatos.Size = new System.Drawing.Size(89, 17);
            this.menuplatos.TabIndex = 7;
            this.menuplatos.Text = "Menú del día";
            this.menuplatos.Click += new System.EventHandler(this.menuplatos_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.menubebidas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1086, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 82);
            this.panel4.TabIndex = 10;
            // 
            // menubebidas
            // 
            this.menubebidas.AutoSize = true;
            this.menubebidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menubebidas.ForeColor = System.Drawing.Color.Yellow;
            this.menubebidas.Location = new System.Drawing.Point(41, 36);
            this.menubebidas.Name = "menubebidas";
            this.menubebidas.Size = new System.Drawing.Size(118, 17);
            this.menubebidas.TabIndex = 7;
            this.menubebidas.Text = "Menú de Bedidas";
            this.menubebidas.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.principal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1286, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 82);
            this.panel2.TabIndex = 9;
            // 
            // principal
            // 
            this.principal.AutoSize = true;
            this.principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.principal.ForeColor = System.Drawing.Color.Yellow;
            this.principal.Location = new System.Drawing.Point(56, 36);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(101, 17);
            this.principal.TabIndex = 7;
            this.principal.Text = "Menú Principal";
            this.principal.Click += new System.EventHandler(this.principal_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::GUI_Comensales.Properties.Resources.TorreDePitzaJaJa;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 82);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pavarotti";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DG_postres
            // 
            this.DG_postres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_postres.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.DG_postres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_postres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_postres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_postres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagen,
            this.Nombre,
            this.Descripcion,
            this.Precio});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_postres.DefaultCellStyle = dataGridViewCellStyle9;
            this.DG_postres.Dock = System.Windows.Forms.DockStyle.Left;
            this.DG_postres.EnableHeadersVisualStyles = false;
            this.DG_postres.GridColor = System.Drawing.Color.NavajoWhite;
            this.DG_postres.Location = new System.Drawing.Point(0, 82);
            this.DG_postres.Margin = new System.Windows.Forms.Padding(4);
            this.DG_postres.Name = "DG_postres";
            this.DG_postres.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_postres.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DG_postres.RowHeadersVisible = false;
            this.DG_postres.RowHeadersWidth = 51;
            this.DG_postres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_postres.Size = new System.Drawing.Size(1159, 683);
            this.DG_postres.TabIndex = 10;
            this.DG_postres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_platos_CellClick);
            // 
            // Imagen
            // 
            this.Imagen.FillWeight = 72.72728F;
            this.Imagen.HeaderText = "";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 72.72728F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 181.8182F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 72.72728F;
            this.Precio.HeaderText = "Precio Bs.";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(151, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(151, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Postre:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.siguiente_button);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.anadidos_dg);
            this.panel3.Controls.Add(this.anadir_postre);
            this.panel3.Controls.Add(this.quitar_postre);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.postre);
            this.panel3.Controls.Add(this.precio_postre);
            this.panel3.Controls.Add(this.cant_platos);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1159, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 683);
            this.panel3.TabIndex = 13;
            // 
            // siguiente_button
            // 
            this.siguiente_button.BackColor = System.Drawing.Color.NavajoWhite;
            this.siguiente_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.siguiente_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siguiente_button.Location = new System.Drawing.Point(365, 840);
            this.siguiente_button.Name = "siguiente_button";
            this.siguiente_button.Size = new System.Drawing.Size(125, 44);
            this.siguiente_button.TabIndex = 22;
            this.siguiente_button.Text = "Siguiente";
            this.siguiente_button.UseVisualStyleBackColor = false;
            this.siguiente_button.Click += new System.EventHandler(this.siguiente_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(78, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Platillos Pedidos";
            // 
            // anadidos_dg
            // 
            this.anadidos_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.anadidos_dg.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.anadidos_dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.anadidos_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.anadidos_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.platillo_p,
            this.cantidad_p,
            this.precio_p});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.anadidos_dg.DefaultCellStyle = dataGridViewCellStyle12;
            this.anadidos_dg.EnableHeadersVisualStyles = false;
            this.anadidos_dg.Location = new System.Drawing.Point(82, 399);
            this.anadidos_dg.Name = "anadidos_dg";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.anadidos_dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.anadidos_dg.RowHeadersVisible = false;
            this.anadidos_dg.RowHeadersWidth = 51;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Wheat;
            this.anadidos_dg.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.anadidos_dg.RowTemplate.Height = 24;
            this.anadidos_dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.anadidos_dg.Size = new System.Drawing.Size(700, 350);
            this.anadidos_dg.TabIndex = 20;
            // 
            // platillo_p
            // 
            this.platillo_p.HeaderText = "Postre";
            this.platillo_p.MinimumWidth = 6;
            this.platillo_p.Name = "platillo_p";
            this.platillo_p.ReadOnly = true;
            // 
            // cantidad_p
            // 
            this.cantidad_p.HeaderText = "Cantidad";
            this.cantidad_p.MinimumWidth = 6;
            this.cantidad_p.Name = "cantidad_p";
            this.cantidad_p.ReadOnly = true;
            // 
            // precio_p
            // 
            this.precio_p.HeaderText = "Precio";
            this.precio_p.MinimumWidth = 6;
            this.precio_p.Name = "precio_p";
            this.precio_p.ReadOnly = true;
            // 
            // anadir_postre
            // 
            this.anadir_postre.BackColor = System.Drawing.Color.NavajoWhite;
            this.anadir_postre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anadir_postre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.anadir_postre.Location = new System.Drawing.Point(350, 261);
            this.anadir_postre.Name = "anadir_postre";
            this.anadir_postre.Size = new System.Drawing.Size(155, 29);
            this.anadir_postre.TabIndex = 19;
            this.anadir_postre.Text = "Añadir a la orden";
            this.anadir_postre.UseVisualStyleBackColor = false;
            this.anadir_postre.Click += new System.EventHandler(this.anadir_postre_Click);
            // 
            // quitar_postre
            // 
            this.quitar_postre.BackColor = System.Drawing.Color.NavajoWhite;
            this.quitar_postre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitar_postre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.quitar_postre.Location = new System.Drawing.Point(570, 261);
            this.quitar_postre.Name = "quitar_postre";
            this.quitar_postre.Size = new System.Drawing.Size(200, 29);
            this.quitar_postre.TabIndex = 18;
            this.quitar_postre.Text = "Quitar de la orden";
            this.quitar_postre.UseVisualStyleBackColor = false;
            this.quitar_postre.Click += new System.EventHandler(this.quitar_plato_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(78, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Detalles";
            // 
            // postre
            // 
            this.postre.AutoSize = true;
            this.postre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.postre.Location = new System.Drawing.Point(242, 89);
            this.postre.Name = "postre";
            this.postre.Size = new System.Drawing.Size(0, 20);
            this.postre.TabIndex = 16;
            // 
            // precio_postre
            // 
            this.precio_postre.AutoSize = true;
            this.precio_postre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.precio_postre.Location = new System.Drawing.Point(600, 153);
            this.precio_postre.Name = "precio_postre";
            this.precio_postre.Size = new System.Drawing.Size(0, 20);
            this.precio_postre.TabIndex = 15;
            // 
            // cant_platos
            // 
            this.cant_platos.BackColor = System.Drawing.Color.SeaShell;
            this.cant_platos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cant_platos.Location = new System.Drawing.Point(246, 150);
            this.cant_platos.Name = "cant_platos";
            this.cant_platos.Size = new System.Drawing.Size(38, 26);
            this.cant_platos.TabIndex = 14;
            this.cant_platos.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(450, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio Total";
            // 
            // MenuPostres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1486, 765);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DG_postres);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPostres";
            this.Text = "MenuPlatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_postres)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anadidos_dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label principal;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_postres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label precio_postre;
        private System.Windows.Forms.TextBox cant_platos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label postre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button anadir_postre;
        private System.Windows.Forms.Button quitar_postre;
        private System.Windows.Forms.DataGridView anadidos_dg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button siguiente_button;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label menuplatos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label menubebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn platillo_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_p;
    }
}