namespace pryAlliaAcademia
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.grbRegistro = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mtbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.grbRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegistro
            // 
            this.grbRegistro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grbRegistro.Controls.Add(this.btnCargar);
            this.grbRegistro.Controls.Add(this.btnRegistrar);
            this.grbRegistro.Controls.Add(this.btnCancelar);
            this.grbRegistro.Controls.Add(this.btnListado);
            this.grbRegistro.Controls.Add(this.chkActivo);
            this.grbRegistro.Controls.Add(this.lblActivo);
            this.grbRegistro.Controls.Add(this.cmbPlan);
            this.grbRegistro.Controls.Add(this.txtNombre);
            this.grbRegistro.Controls.Add(this.lblPlan);
            this.grbRegistro.Controls.Add(this.lblNombre);
            this.grbRegistro.Controls.Add(this.lblCodigo);
            this.grbRegistro.Controls.Add(this.mtbCodigo);
            this.grbRegistro.Font = new System.Drawing.Font("Tahoma", 11F);
            this.grbRegistro.Location = new System.Drawing.Point(16, 17);
            this.grbRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegistro.Name = "grbRegistro";
            this.grbRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegistro.Size = new System.Drawing.Size(339, 277);
            this.grbRegistro.TabIndex = 0;
            this.grbRegistro.TabStop = false;
            this.grbRegistro.Text = "Registro Materia / Asignatura";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCargar.Location = new System.Drawing.Point(12, 239);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(319, 32);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar de Plan";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnRegistrar.Location = new System.Drawing.Point(229, 199);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 32);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(122, 199);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnListado
            // 
            this.btnListado.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnListado.Location = new System.Drawing.Point(12, 199);
            this.btnListado.Margin = new System.Windows.Forms.Padding(4);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(102, 32);
            this.btnListado.TabIndex = 8;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(111, 167);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(18, 17);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblActivo.Location = new System.Drawing.Point(8, 164);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(59, 23);
            this.lblActivo.TabIndex = 6;
            this.lblActivo.Text = "Activo";
            // 
            // cmbPlan
            // 
            this.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlan.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbPlan.Location = new System.Drawing.Point(111, 121);
            this.cmbPlan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(220, 30);
            this.cmbPlan.TabIndex = 5;
            this.cmbPlan.SelectedIndexChanged += new System.EventHandler(this.cmbPlan_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNombre.Location = new System.Drawing.Point(111, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 30);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblPlan.Location = new System.Drawing.Point(8, 124);
            this.lblPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(45, 23);
            this.lblPlan.TabIndex = 3;
            this.lblPlan.Text = "Plan";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblNombre.Location = new System.Drawing.Point(8, 81);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblCodigo.Location = new System.Drawing.Point(8, 38);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 23);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // mtbCodigo
            // 
            this.mtbCodigo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.mtbCodigo.Location = new System.Drawing.Point(111, 35);
            this.mtbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCodigo.Mask = "999999";
            this.mtbCodigo.Name = "mtbCodigo";
            this.mtbCodigo.Size = new System.Drawing.Size(220, 30);
            this.mtbCodigo.TabIndex = 0;
            this.mtbCodigo.ValidatingType = typeof(int);
            this.mtbCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCodigo_MaskInputRejected);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 307);
            this.Controls.Add(this.grbRegistro);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro - Academia";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.grbRegistro.ResumeLayout(false);
            this.grbRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegistro;
        private System.Windows.Forms.MaskedTextBox mtbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnCargar;
    }
}