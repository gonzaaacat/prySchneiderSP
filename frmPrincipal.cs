using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySchneiderSP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClie = new frmClientes();
            frmClie.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registroDeVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor frmVen = new frmVendedor();    
            frmVen.ShowDialog();   
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frmVent = new frmVentas();
            frmVent.ShowDialog();
        }
    }
}
