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
        }
    }
}
