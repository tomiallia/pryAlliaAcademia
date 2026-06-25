using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAlliaAcademia
{
    public partial class frmAlumno : Form
    {
        private int editingRowIndex = -1;
        public frmAlumno()
        {
            InitializeComponent();
            btnEditar.Click += btnEditar_Click;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Add(txtDni.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtContacto.Text, txtNacimiento.Text);

            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtContacto.Clear();
            txtNacimiento.Clear();
            txtDni.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = dgvAlumnos.SelectedRows[0].Index;

            // Si no estamos en modo edición o se seleccionó otra fila, cargar valores en las cajas para editar
            if (editingRowIndex != selectedIndex)
            {
                editingRowIndex = selectedIndex;
                var row = dgvAlumnos.Rows[editingRowIndex];
                txtDni.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                txtNombre.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                txtApellido.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                txtDireccion.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                txtContacto.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                txtNacimiento.Text = row.Cells[5].Value?.ToString() ?? string.Empty;
                txtDni.Focus();
                return;
            }

            // Si ya estábamos en modo edición sobre la fila seleccionada, guardar cambios
            var editRow = dgvAlumnos.Rows[editingRowIndex];
            editRow.Cells[0].Value = txtDni.Text;
            editRow.Cells[1].Value = txtNombre.Text;
            editRow.Cells[2].Value = txtApellido.Text;
            editRow.Cells[3].Value = txtDireccion.Text;
            editRow.Cells[4].Value = txtContacto.Text;
            editRow.Cells[5].Value = txtNacimiento.Text;

            // Limpiar estado de edición
            editingRowIndex = -1;
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtContacto.Clear();
            txtNacimiento.Clear();
            txtDni.Focus();
        }
    }
}
