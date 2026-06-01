using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAlliaAcademia
{
    public partial class frmRegistro : Form
    {
        string estado;

        public frmRegistro()
        {
            InitializeComponent();

            txtNombre.Enabled = false;
            cmbPlan.Enabled = false;
            chkActivo.Enabled = false;
            btnRegistrar.Enabled = false;
            btnListado.Enabled = false;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(mtbCodigo.Text) == "")
            {
                MessageBox.Show("Ingresa un codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCodigo.Focus();
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (cmbPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPlan.Focus();
                return;
            }
            if (chkActivo.Checked == true)
            {
                estado = "activo";
            }
            else 
            {
                estado = "inactivo";
            }

            mtbCodigo.Clear();
            txtNombre.Clear();
            cmbPlan.SelectedIndex = -1;

            MessageBox.Show("Registro exitoso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mtbCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbCodigo.Text != "")   
            {
                txtNombre.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                cmbPlan.Enabled = true;
            }
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedIndex != -1)
            {
                chkActivo.Enabled = true;
                btnRegistrar.Enabled = true;
                btnListado.Enabled = true;
            }
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmLIstado frmLIstado = new frmLIstado();
            frmLIstado.ShowDialog();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            frmPlan frmPlan = new frmPlan();
            frmPlan.ShowDialog();
            this.Close();
        }
    }
}
