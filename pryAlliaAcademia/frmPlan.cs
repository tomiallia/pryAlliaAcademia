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
    public partial class frmPlan : Form
    {
        public frmPlan()
        {
            InitializeComponent();
        }
        private void CargarPlan()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre de plan", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else
            {
                boxPlan.Items.Add(txtNombre.Text);
                txtNombre.Clear();
                txtNombre.Focus();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea cargar el plan?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarPlan();
                e.SuppressKeyPress = true;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmLIstado frmLIstado = new frmLIstado();
            frmLIstado.ShowDialog();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            string plan = txtNombre.Text.Trim();

            if (plan == "")
            {
                MessageBox.Show("Ingresá el nombre del plan.");
                txtNombre.Focus();
                return;
            }

            if (DatosAcademia.Planes.Contains(plan))
            {
                MessageBox.Show("Ese plan ya está cargado.");
                txtNombre.Clear();
                txtNombre.Focus();
                return;
            }

            DatosAcademia.Planes.Add(plan);
            boxPlan.Items.Add(plan);

            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void frmPlan_Load(object sender, EventArgs e)
        {
            boxPlan.Items.Clear();

            foreach (string plan in DatosAcademia.Planes)
            {
                boxPlan.Items.Add(plan);
            }
        }
    }
}
