namespace NuevasCarrerasApp1
{
    partial class NuevoPlan
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
            this.lblNuevoPl = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtCuatri = new System.Windows.Forms.TextBox();
            this.lblCuatri = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.IdAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevoPl
            // 
            this.lblNuevoPl.AutoSize = true;
            this.lblNuevoPl.Location = new System.Drawing.Point(202, 19);
            this.lblNuevoPl.Name = "lblNuevoPl";
            this.lblNuevoPl.Size = new System.Drawing.Size(145, 13);
            this.lblNuevoPl.TabIndex = 0;
            this.lblNuevoPl.Text = "NUEVO PLAN DE ESTUDIO";
            this.lblNuevoPl.Click += new System.EventHandler(this.lblNuevoPl_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(127, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre carrera:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(226, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(125, 179);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 4;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(34, 186);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(85, 13);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año de cursado:";
            // 
            // txtCuatri
            // 
            this.txtCuatri.Location = new System.Drawing.Point(371, 183);
            this.txtCuatri.Name = "txtCuatri";
            this.txtCuatri.Size = new System.Drawing.Size(100, 20);
            this.txtCuatri.TabIndex = 6;
            // 
            // lblCuatri
            // 
            this.lblCuatri.AutoSize = true;
            this.lblCuatri.Location = new System.Drawing.Point(297, 186);
            this.lblCuatri.Name = "lblCuatri";
            this.lblCuatri.Size = new System.Drawing.Size(68, 13);
            this.lblCuatri.TabIndex = 5;
            this.lblCuatri.Text = "Cuatrimestre:";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(150, 113);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(60, 13);
            this.lblAsignatura.TabIndex = 7;
            this.lblAsignatura.Text = "Asignatura:";
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(226, 110);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(121, 21);
            this.cboAsignatura.TabIndex = 8;
            this.cboAsignatura.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAsignatura,
            this.Asignatura,
            this.AnioCursado,
            this.Cuatrimestre});
            this.dgvDetalles.Location = new System.Drawing.Point(37, 236);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(444, 150);
            this.dgvDetalles.TabIndex = 9;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(205, 392);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Detalle";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(292, 434);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 24);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // IdAsignatura
            // 
            this.IdAsignatura.HeaderText = "Id Asignatura";
            this.IdAsignatura.Name = "IdAsignatura";
            // 
            // Asignatura
            // 
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.Name = "Asignatura";
            // 
            // AnioCursado
            // 
            this.AnioCursado.HeaderText = "Año Cursado";
            this.AnioCursado.Name = "AnioCursado";
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(112, 434);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // NuevoPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 491);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.txtCuatri);
            this.Controls.Add(this.lblCuatri);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNuevoPl);
            this.Name = "NuevoPlan";
            this.Text = "Nuevo Plan";
            this.Load += new System.EventHandler(this.NuevoPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoPl;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtCuatri;
        private System.Windows.Forms.Label lblCuatri;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.Button btnGuardar;
    }
}

