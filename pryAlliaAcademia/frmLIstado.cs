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
    public partial class frmLIstado : Form
    {
        public frmLIstado()
        {
            InitializeComponent();

            this.Load += frmListado_Load;
            btnBuscar.Click += btnBuscar_Click;
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            CargarPlanes();

            rbtnTodo.Checked = true;

            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            cmbPlan.Enabled = false;
        }

        private void CargarPlanes()
        {
            cmbPlan.Items.Clear();

            foreach (string plan in DatosAcademia.Planes)
            {
                cmbPlan.Items.Add(plan);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();

            if (rbtnTodo.Checked == true)
            {
                foreach (Materia materia in DatosAcademia.Materias)
                {
                    dgvListado.Rows.Add(materia.Codigo, materia.Nombre, materia.Plan, materia.Activo);
                }
            }

            if (rbtnCodigo.Checked == true)
            {
                foreach (Materia materia in DatosAcademia.Materias)
                {
                    if (materia.Codigo == txtCodigo.Text)
                    {
                        dgvListado.Rows.Add(materia.Codigo, materia.Nombre, materia.Plan, materia.Activo);
                    }
                }
            }

            if (rbtnNombre.Checked == true)
            {
                foreach (Materia materia in DatosAcademia.Materias)
                {
                    if (materia.Nombre == txtNombre.Text)
                    {
                        dgvListado.Rows.Add(materia.Codigo, materia.Nombre, materia.Plan, materia.Activo);
                    }
                }
            }

            if (rbtnPlan.Checked == true)
            {
                foreach (Materia materia in DatosAcademia.Materias)
                {
                    if (materia.Plan == cmbPlan.Text)
                    {
                        dgvListado.Rows.Add(materia.Codigo, materia.Nombre, materia.Plan, materia.Activo);
                    }
                }
            }
        }

        //cuando cambia el estado del check pasa lo siguiente
        private void rbtnTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTodo.Checked == true)
            {
                txtCodigo.Enabled = false;
                txtNombre.Enabled = false;
                cmbPlan.Enabled = false;

                txtCodigo.Clear();
                txtNombre.Clear();
                cmbPlan.SelectedIndex = -1;
            }
        }

        private void rbtnCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCodigo.Checked == true)
            {
                txtCodigo.Enabled = true;
                txtNombre.Enabled = false;
                cmbPlan.Enabled = false;

                txtNombre.Clear();
                cmbPlan.SelectedIndex = -1;

                txtCodigo.Focus();
            }
        }

        private void rbtnNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNombre.Checked == true)
            {
                txtCodigo.Enabled = false;
                txtNombre.Enabled = true;
                cmbPlan.Enabled = false;

                txtCodigo.Clear();
                cmbPlan.SelectedIndex = -1;

                txtNombre.Focus();
            }
        }

        private void rbtnPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPlan.Checked == true)
            {
                txtCodigo.Enabled = false;
                txtNombre.Enabled = false;
                cmbPlan.Enabled = true;

                txtCodigo.Clear();
                txtNombre.Clear();

                cmbPlan.Focus();
            }
        }
        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sino se me buguea el designer
        }

        private void gboxBuscar_Enter(object sender, EventArgs e)
        {

        }
    }
}