using System;
using System.Windows.Forms;

namespace pryAlliaAcademia
{
    public partial class frmRegistro : Form
    {
        string estado;

        public frmRegistro()
        {
            InitializeComponent();

            this.Load += frmRegistro_Load;
            mtbCodigo.TextChanged += mtbCodigo_TextChanged;

            txtNombre.Enabled = false;
            cmbPlan.Enabled = false;
            chkActivo.Enabled = false;
            btnRegistrar.Enabled = false;

            btnListado.Enabled = true;
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            CargarPlanes();
        }

        private void CargarPlanes()
        {
            cmbPlan.Items.Clear();

            foreach (string plan in DatosAcademia.Planes)
            {
                cmbPlan.Items.Add(plan);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (mtbCodigo.Text == "")
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

            Materia nuevaMateria = new Materia();

            nuevaMateria.Codigo = mtbCodigo.Text;
            nuevaMateria.Nombre = txtNombre.Text;
            nuevaMateria.Plan = cmbPlan.Text;
            nuevaMateria.Activo = chkActivo.Checked;

            DatosAcademia.Materias.Add(nuevaMateria);

            MessageBox.Show("Registro exitoso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mtbCodigo.Clear();
            txtNombre.Clear();
            cmbPlan.SelectedIndex = -1;
            chkActivo.Checked = false;

            txtNombre.Enabled = false;
            cmbPlan.Enabled = false;
            chkActivo.Enabled = false;
            btnRegistrar.Enabled = false;

            mtbCodigo.Focus();
        }

        private void mtbCodigo_TextChanged(object sender, EventArgs e)
        {
            if (mtbCodigo.Text != "")
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
                cmbPlan.Enabled = false;
                chkActivo.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }

        private void mtbCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                cmbPlan.Enabled = true;
            }
            else
            {
                cmbPlan.Enabled = false;
                chkActivo.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlan.SelectedIndex != -1)
            {
                chkActivo.Enabled = true;
                btnRegistrar.Enabled = true;
            }
            else
            {
                chkActivo.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmLIstado listado = new frmLIstado();
            listado.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            frmPlan plan = new frmPlan();
            plan.ShowDialog();

            CargarPlanes();
        }
    }
}