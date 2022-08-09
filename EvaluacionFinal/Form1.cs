using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionFinal
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
        }

        private void tsProv_Click(object sender, EventArgs e)
        {
            frmProveedor prov = new frmProveedor();
            prov.Show();
        }

        private void tsCompras_Click(object sender, EventArgs e)
        {
            frmCompras compras = new frmCompras();
            compras.Show();
        }
        private void tsProd_Click(object sender, EventArgs e)
        {
            frmProducto prod = new frmProducto();
            prod.Show();
        }

        private void tsFact_Click(object sender, EventArgs e)
        {
            frmFactura factura = new frmFactura();
            factura.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor prov = new frmProveedor();
            prov.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras compras = new frmCompras();
            compras.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto prod = new frmProducto();
            prod.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura factura = new frmFactura();
            factura.Show();
        }
    }
}
