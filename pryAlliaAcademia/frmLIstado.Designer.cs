namespace pryAlliaAcademia
{
    partial class frmLIstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLIstado));
            this.gboxBuscar = new System.Windows.Forms.GroupBox();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.rbtnPlan = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.rbtnTodo = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxBuscar
            // 
            this.gboxBuscar.Controls.Add(this.cmbPlan);
            this.gboxBuscar.Controls.Add(this.txtNombre);
            this.gboxBuscar.Controls.Add(this.txtCodigo);
            this.gboxBuscar.Controls.Add(this.rbtnPlan);
            this.gboxBuscar.Controls.Add(this.rbtnNombre);
            this.gboxBuscar.Controls.Add(this.rbtnCodigo);
            this.gboxBuscar.Controls.Add(this.rbtnTodo);
            this.gboxBuscar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gboxBuscar.Location = new System.Drawing.Point(12, 12);
            this.gboxBuscar.Name = "gboxBuscar";
            this.gboxBuscar.Size = new System.Drawing.Size(282, 217);
            this.gboxBuscar.TabIndex = 0;
            this.gboxBuscar.TabStop = false;
            this.gboxBuscar.Text = "Buscar";
            this.gboxBuscar.Enter += new System.EventHandler(this.gboxBuscar_Enter);
            // 
            // cmbPlan
            // 
            this.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(110, 167);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(162, 26);
            this.cmbPlan.TabIndex = 5;
            this.cmbPlan.SelectedIndexChanged += new System.EventHandler(this.cmbPlan_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 25);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(110, 79);
            this.txtCodigo.Mask = "999999";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(162, 25);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.ValidatingType = typeof(int);
            // 
            // rbtnPlan
            // 
            this.rbtnPlan.AutoSize = true;
            this.rbtnPlan.Location = new System.Drawing.Point(6, 170);
            this.rbtnPlan.Name = "rbtnPlan";
            this.rbtnPlan.Size = new System.Drawing.Size(52, 22);
            this.rbtnPlan.TabIndex = 3;
            this.rbtnPlan.TabStop = true;
            this.rbtnPlan.Text = "Plan";
            this.rbtnPlan.UseVisualStyleBackColor = true;
            this.rbtnPlan.CheckedChanged += new System.EventHandler(this.rbtnPlan_CheckedChanged);
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(6, 124);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(78, 22);
            this.rbtnNombre.TabIndex = 2;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            this.rbtnNombre.CheckedChanged += new System.EventHandler(this.rbtnNombre_CheckedChanged);
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Location = new System.Drawing.Point(6, 79);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(69, 22);
            this.rbtnCodigo.TabIndex = 1;
            this.rbtnCodigo.TabStop = true;
            this.rbtnCodigo.Text = "Código";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            this.rbtnCodigo.CheckedChanged += new System.EventHandler(this.rbtnCodigo_CheckedChanged);
            // 
            // rbtnTodo
            // 
            this.rbtnTodo.AutoSize = true;
            this.rbtnTodo.Location = new System.Drawing.Point(6, 35);
            this.rbtnTodo.Name = "rbtnTodo";
            this.rbtnTodo.Size = new System.Drawing.Size(60, 22);
            this.rbtnTodo.TabIndex = 0;
            this.rbtnTodo.TabStop = true;
            this.rbtnTodo.Text = "Todo";
            this.rbtnTodo.UseVisualStyleBackColor = true;
            this.rbtnTodo.CheckedChanged += new System.EventHandler(this.rbtnTodo_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(12, 235);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(282, 37);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.materia,
            this.activo});
            this.dgvListado.Location = new System.Drawing.Point(300, 25);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.Size = new System.Drawing.Size(611, 247);
            this.dgvListado.TabIndex = 2;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // materia
            // 
            this.materia.HeaderText = "Plan";
            this.materia.MinimumWidth = 6;
            this.materia.Name = "materia";
            this.materia.Width = 125;
            // 
            // activo
            // 
            this.activo.HeaderText = "Activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.Width = 125;
            // 
            // frmLIstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 283);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gboxBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLIstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado - Academia";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.gboxBuscar.ResumeLayout(false);
            this.gboxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxBuscar;
        private System.Windows.Forms.RadioButton rbtnPlan;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private System.Windows.Forms.RadioButton rbtnTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
    }
}