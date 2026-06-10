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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLIstado frmLIstado = new frmLIstado();
            frmLIstado.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.ShowDialog();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlumno = new frmAlumno();
            frmAlumno.ShowDialog();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlan frmPlan = new frmPlan();
            frmPlan.ShowDialog();
        }
    }
}
