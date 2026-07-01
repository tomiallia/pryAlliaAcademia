namespace pryAlliaAcademia
{
    partial class frmAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumno));
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.MaskedTextBox();
            this.txtNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.Coldni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colapellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colcontacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(9, 21);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(34, 18);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(9, 130);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(55, 18);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(9, 182);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(65, 18);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(9, 236);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(66, 18);
            this.lblContacto.TabIndex = 4;
            this.lblContacto.Text = "Contacto";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(9, 293);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(123, 18);
            this.lblNacimiento.TabIndex = 5;
            this.lblNacimiento.Text = "Fecha Nacimiento";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(194, 18);
            this.txtDni.Mask = "99.999.999";
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(167, 25);
            this.txtDni.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(194, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 25);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(194, 127);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 25);
            this.txtApellido.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(194, 179);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(167, 25);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(194, 233);
            this.txtContacto.Mask = "(999)000-0000";
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(167, 25);
            this.txtContacto.TabIndex = 10;
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Location = new System.Drawing.Point(194, 286);
            this.txtNacimiento.Mask = "00/00/0000";
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(167, 25);
            this.txtNacimiento.TabIndex = 11;
            this.txtNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(13, 342);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(112, 33);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(131, 342);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 33);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(249, 342);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 33);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coldni,
            this.Colnombre,
            this.Colapellido,
            this.Coldireccion,
            this.Colcontacto,
            this.colNacimiento});
            this.dgvAlumnos.Location = new System.Drawing.Point(378, 18);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(898, 357);
            this.dgvAlumnos.TabIndex = 15;
            // 
            // Coldni
            // 
            this.Coldni.HeaderText = "DNI";
            this.Coldni.MinimumWidth = 6;
            this.Coldni.Name = "Coldni";
            this.Coldni.Width = 125;
            // 
            // Colnombre
            // 
            this.Colnombre.HeaderText = "Nombre";
            this.Colnombre.MinimumWidth = 6;
            this.Colnombre.Name = "Colnombre";
            this.Colnombre.Width = 125;
            // 
            // Colapellido
            // 
            this.Colapellido.HeaderText = "Apellido";
            this.Colapellido.MinimumWidth = 6;
            this.Colapellido.Name = "Colapellido";
            this.Colapellido.Width = 125;
            // 
            // Coldireccion
            // 
            this.Coldireccion.HeaderText = "Dirección";
            this.Coldireccion.MinimumWidth = 6;
            this.Coldireccion.Name = "Coldireccion";
            this.Coldireccion.Width = 125;
            // 
            // Colcontacto
            // 
            this.Colcontacto.HeaderText = "Contacto";
            this.Colcontacto.MinimumWidth = 6;
            this.Colcontacto.Name = "Colcontacto";
            this.Colcontacto.Width = 125;
            // 
            // colNacimiento
            // 
            this.colNacimiento.HeaderText = "Fecha de Nacimiento";
            this.colNacimiento.MinimumWidth = 6;
            this.colNacimiento.Name = "colNacimiento";
            this.colNacimiento.Width = 125;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 393);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtNacimiento);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Alumno - Academia";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.MaskedTextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox txtContacto;
        private System.Windows.Forms.MaskedTextBox txtNacimiento;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colapellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colcontacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacimiento;
    }
}