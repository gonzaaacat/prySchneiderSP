using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySchneiderSP1
{
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (chkActivo.Checked == true)
            {
                if (chkComisión.Checked == true)
                {
                    TextWriter Escribir = new StreamWriter("./Vendedor.txt", true);

                    Escribir.WriteLine(Convert.ToString(txtIdentificadorVendedor.Text + " " + txtNombreVendedor.Text + " " + "Activo: SI" + " // " + "Comisión:SI"));
                    Escribir.Close();
                    MessageBox.Show("El vendedor se guardo correctamente");
                }

            }
            if (chkComisión.Checked == false)
            {
                TextWriter Escribir = new StreamWriter("./Vendedor.txt", true);

                Escribir.WriteLine(Convert.ToString(txtIdentificadorVendedor.Text + " " + txtNombreVendedor.Text + " " + "Activo: SI" + " // " + "Comisión:NO"));
                Escribir.Close();
                MessageBox.Show("El vendedor se guardo correctamente");
            }
            if (chkActivo.Checked == false)
            {
                if (chkComisión.Checked == true)
                {
                    TextWriter Escribir = new StreamWriter("./Vendedor.txt", true);

                    Escribir.WriteLine(Convert.ToString(txtIdentificadorVendedor.Text + " " + txtNombreVendedor.Text + " " + "Activo: NO" + " // " + "Comisión:SI"));
                    Escribir.Close();
                    MessageBox.Show("El vendedor se guardo correctamente");
                }
                if (chkActivo.Checked == false)
                {
                    TextWriter Escribir = new StreamWriter("./Vendedor.txt", true);

                    Escribir.WriteLine(Convert.ToString(txtIdentificadorVendedor.Text + " " + txtNombreVendedor.Text + " " + "Activo: SI" + " // " + "Comisión:NO"));
                    Escribir.Close();
                    MessageBox.Show("El vendedor se guardo correctamente");
                }
            }
        }        
        private void txtNombreVendedor_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreVendedor.Text != "")
            {
                btnAceptar.Enabled = true;
            }
        }
    }
}
