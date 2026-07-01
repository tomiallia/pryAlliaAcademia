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
            if (editingRowIndex == -1)
            {
                if (dgvAlumnos.CurrentRow == null || dgvAlumnos.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Seleccione una fila para editar.");
                    return;
                }

                editingRowIndex = dgvAlumnos.CurrentRow.Index;

                txtDni.Text = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
                txtContacto.Text = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
                txtNacimiento.Text = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();

                MessageBox.Show("Modifique los datos y vuelva a tocar Editar para guardar.");
                txtDni.Focus();
            }
            else
            {
                dgvAlumnos.Rows[editingRowIndex].Cells[0].Value = txtDni.Text;
                dgvAlumnos.Rows[editingRowIndex].Cells[1].Value = txtNombre.Text;
                dgvAlumnos.Rows[editingRowIndex].Cells[2].Value = txtApellido.Text;
                dgvAlumnos.Rows[editingRowIndex].Cells[3].Value = txtDireccion.Text;
                dgvAlumnos.Rows[editingRowIndex].Cells[4].Value = txtContacto.Text;
                dgvAlumnos.Rows[editingRowIndex].Cells[5].Value = txtNacimiento.Text;

                MessageBox.Show("Alumno editado correctamente.");

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null || dgvAlumnos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccioná una fila para borrar.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvAlumnos.Rows.Remove(dgvAlumnos.CurrentRow);
            MessageBox.Show("Alumno eliminado correctamente.");
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            txtDni.Enabled = true;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtContacto.Enabled = false;
            txtNacimiento.Enabled = false;
            btnCargar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text != "")
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtApellido.Enabled = true;
            }
            else
            {
                txtApellido.Enabled = false;
            }
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "")
            {
                txtDireccion.Enabled = true;
            }
            else
            {
                txtDireccion.Enabled = false;
            }
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text != "")
            {
                txtContacto.Enabled = true;
            }
            else
            {
                txtContacto.Enabled = false;
            }
        }
        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text != "")
            {
                txtNacimiento.Enabled = true;
            }
            else
            {
                txtNacimiento.Enabled = false;
            }
        }
        private void txtNacimiento_TextChanged(object sender, EventArgs e)
        {
            if (txtNacimiento.Text != "")
            {
                btnCargar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

            }
        }
    }
}
