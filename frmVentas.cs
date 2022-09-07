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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            StreamReader clientesReader = new StreamReader("./clientes.txt");
            StreamReader vendedorReader = new StreamReader("./vendedor.txt");

            char separador = Convert.ToChar("");

            while (!clientesReader.EndOfStream)
            {
                string[] clientes = clientesReader.ReadLine().Split(separador);
                cbClientes.Items.Add(clientes[0]);
            }
            while (!vendedorReader.EndOfStream)
            {
                string[] vendedor = vendedorReader.ReadLine().Split(separador);
                cbVendedor.Items.Add(vendedor[0]);
            }
            clientesReader.Close();
            vendedorReader.Close();
        }
    }
}
