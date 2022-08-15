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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }
        private double total = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<OBTENER_DCOMPRAS_Result> visualizar(int numFacturaCompra)
        {
            try
            {
                using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
                {
                    var consulta = bd.OBTENER_DCOMPRAS(null).ToList();

                    if (numFacturaCompra > 0)
                    {
                        consulta = bd.OBTENER_DCOMPRAS(numFacturaCompra).ToList();
                    }

                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> listarProductos()
        {
            try
            {
                using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
                {
                    var consulta = bd.LISTA_PRODUCTOS().ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string retonarCodProducto(string descripcion)
        {
            string aux = "";
            using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
            {
                var productos = from prod in bd.Producto where prod.Descripcion == descripcion select prod;
                foreach (Producto prod in productos)
                {
                    aux = prod.Codpro;
                }
            }
            return aux;
        }
        public void mostrarPrecio(string descripcion)
        {
            using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
            {
                var productos = from prod in bd.Producto where prod.Descripcion == descripcion select prod;
                foreach (Producto prod in productos)
                {
                    txtPrecio.Text = prod.Precio.ToString();
                }
            }
        }
        public void mostrarDatosProveedor(string cod)
        {
            using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
            {
                var proveedores = from prov in bd.Proveedor where prov.CODP == cod select prov;
                foreach (Proveedor prov in proveedores)
                {
                    txtDatos.Text = prov.DATPRO;
                    txtDireccion.Text = prov.DIRPRO;
                }
            }
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            dgvCompras.DataSource = visualizar(0);
            cmbProductos.DataSource = listarProductos();
        }

        private void mostrarImportesTotales(int num)
        {
            using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
            {
                var compra = from comp in bd.FacturaCompra where comp.NUM == num select comp;
                foreach (FacturaCompra comp in compra)
                {
                    txtTotal.Text = comp.SUBTOTAL.ToString();
                    txtIGV.Text = comp.IGV.ToString();
                    txtNeto.Text = comp.TOTGRAL.ToString();
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNfact.Text.Length > 0)
            {
                dgvCompras.DataSource = visualizar(Convert.ToInt32(txtNfact.Text));
                mostrarImportesTotales(Convert.ToInt32(txtNfact.Text));
            }
            else
            {
                dgvCompras.DataSource = visualizar(0);
            }
        }

        public void guardarDetalleCompra()
        {
            try
            {
                using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
                {
                    if (total == 0)
                    {
                        FacturaCompra compra = new FacturaCompra();
                        compra.CODP = txtCodp.Text;
                        bd.FacturaCompra.Add(compra);
                        bd.SaveChanges();
                        txtNfact.Text = compra.NUM.ToString();//muestra el numero de factura por pantalla
                    }

                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    double precio = Convert.ToDouble(txtPrecio.Text);
                    double importe = cantidad * precio;

                    DetalleCompra dcompra = new DetalleCompra();
                    dcompra.NUM = Convert.ToInt32(txtNfact.Text);
                    dcompra.Codpro = retonarCodProducto(cmbProductos.Text);
                    dcompra.can = cantidad;
                    dcompra.pun = precio;
                    dcompra.impo = importe;
                    bd.DetalleCompra.Add(dcompra);
                    bd.SaveChanges();
                    /***********Sumatorias************/
                    total += importe;
                    txtTotal.Text = total.ToString();
                    txtIGV.Text = (0.18 * total).ToString();
                    txtNeto.Text = (1.18 * total).ToString();
                }
                dgvCompras.DataSource = visualizar(Convert.ToInt32(txtNfact.Text));
                MessageBox.Show("Datos guardados satisfactoriamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                throw;
            }
        }
        private void gestionarCompra()
        {
            try
            {
                using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
                {
                    FacturaCompra compra = new FacturaCompra();
                    compra.NUM = Convert.ToInt32(txtNfact.Text);
                    compra.FECHA = Convert.ToDateTime(dtFecha.Text);
                    compra.SUBTOTAL = Convert.ToDouble(txtTotal.Text);
                    compra.IGV = Convert.ToDouble(txtIGV.Text);
                    compra.TOTGRAL = Convert.ToDouble(txtNeto.Text);
                    compra.CODP = txtCodp.Text;
                    bd.Entry(compra).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
                MessageBox.Show("Compra Realizada exitosamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            guardarDetalleCompra();
        }

        private void btnGestionarc_Click(object sender, EventArgs e)
        {
            total = 0;
            gestionarCompra();
        }

        private void txtCodp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                mostrarDatosProveedor(txtCodp.Text);
                cmbProductos.Focus();
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            mostrarPrecio(cmbProductos.Text);
        }
    }
}
