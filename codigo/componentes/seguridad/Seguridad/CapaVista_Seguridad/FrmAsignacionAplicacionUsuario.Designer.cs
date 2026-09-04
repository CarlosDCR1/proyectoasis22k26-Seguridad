namespace CapaVista_Seguridad
{
    partial class FrmAsignacionAplicacionUsuario
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
            this.btnAyuda = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.cmbAplicacion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.colIngresar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(786, -55);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 21;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblUsuario);
            this.grpDatos.Controls.Add(this.cmbUsuario);
            this.grpDatos.Controls.Add(this.lblModulo);
            this.grpDatos.Controls.Add(this.cmbModulo);
            this.grpDatos.Controls.Add(this.lblAplicacion);
            this.grpDatos.Controls.Add(this.cmbAplicacion);
            this.grpDatos.Controls.Add(this.btnAgregar);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(12, 121);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(850, 115);
            this.grpDatos.TabIndex = 19;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(60, 41);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(6, 71);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(160, 23);
            this.cmbUsuario.TabIndex = 2;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(239, 41);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(49, 15);
            this.lblModulo.TabIndex = 3;
            this.lblModulo.Text = "Módulo";
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(200, 73);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(160, 23);
            this.cmbModulo.TabIndex = 4;
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacion.Location = new System.Drawing.Point(444, 41);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(63, 15);
            this.lblAplicacion.TabIndex = 5;
            this.lblAplicacion.Text = "Aplicación";
            // 
            // cmbAplicacion
            // 
            this.cmbAplicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAplicacion.FormattingEnabled = true;
            this.cmbAplicacion.Location = new System.Drawing.Point(402, 71);
            this.cmbAplicacion.Name = "cmbAplicacion";
            this.cmbAplicacion.Size = new System.Drawing.Size(160, 23);
            this.cmbAplicacion.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(677, 59);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 35);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Form Bitacora";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // colIngresar
            // 
            this.colIngresar.HeaderText = "Ingresar";
            this.colIngresar.Name = "colIngresar";
            this.colIngresar.ReadOnly = true;
            // 
            // colAplicacion
            // 
            this.colAplicacion.HeaderText = "Aplicación";
            this.colAplicacion.Name = "colAplicacion";
            this.colAplicacion.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // dgvAsignaciones
            // 
            this.dgvAsignaciones.AllowUserToAddRows = false;
            this.dgvAsignaciones.AllowUserToDeleteRows = false;
            this.dgvAsignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsuario,
            this.colAplicacion,
            this.colIngresar});
            this.dgvAsignaciones.Location = new System.Drawing.Point(6, 20);
            this.dgvAsignaciones.MultiSelect = false;
            this.dgvAsignaciones.Name = "dgvAsignaciones";
            this.dgvAsignaciones.ReadOnly = true;
            this.dgvAsignaciones.RowHeadersVisible = false;
            this.dgvAsignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignaciones.Size = new System.Drawing.Size(627, 277);
            this.dgvAsignaciones.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(687, 199);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 35);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAsignaciones);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 315);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignaciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(687, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 35);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(687, 79);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(100, 35);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(687, 142);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 35);
            this.btnInsertar.TabIndex = 10;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-60, -67);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(342, 24);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Asignación de Aplicación a Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Asignación de Aplicación a Usuario";
            // 
            // FrmAsignacionAplicacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAsignacionAplicacionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Aplicación a Usuario";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.ComboBox cmbAplicacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridView dgvAsignaciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}