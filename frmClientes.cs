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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text !="")
            {
                btnAceptar.Enabled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TextWriter Escribir = new StreamWriter("./Clientes.txt", true);

            Escribir.WriteLine(Convert.ToString(txtID.Text + " " + txtNombre.Text));
            Escribir.Close();

            MessageBox.Show("El cliente se guardo correctamente");

            txtNombre.Text = "";
            txtID.Text = "";
            txtNombre.Focus();
        }
    }
}
