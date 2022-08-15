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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }
        double total = 0;
        cFacturacion a = new cFacturacion();
        /*public List<string> listarProductos()
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
        }*/
        public bool formulariovalido() //Valida el guardado
        {
            bool vali = false;

            string codc = txtCodc.Text.Trim();
            string raz = txtRsocial.Text.Trim();
            string prod = cmbProductos.Text;
            string prec = txtPrecio.Text.Trim();
            string cant = txtCantidad.Text.Trim();
            string nf = txtNfact.Text.Trim();

            if (codc.Length > 0 && raz.Length > 0 && prod.Length > 0 && nf.Length > 0 &&
                prec.Length > 0 && cant.Length > 0)
            {
                vali = true;
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodc.Focus();
            }
            return vali;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodc_Leave(object sender, EventArgs e)
        {
            //txtRsocial.Text = Convert.ToString(a.obtenerNombreCliente(txtCodc.Text));
        }

        private void txtCodc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRsocial.Focus();
            }
            Validaciones.validarNumeros(e);
        }

        private void txtRsocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.validarLetras(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.validarNumeros(e);
        }

        private void txtNfact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.validarNumeros(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            double precio = Convert.ToDouble(txtPrecio.Text.Trim());
            double imp = cantidad * precio;
            if (formulariovalido())
            {
                /*DetalleFactura factura = new DetalleFactura();
                factura.NFAC = Convert.ToInt32(txtNfact.Text.Trim());
                factura.Codpro = cmbProductos.SelectedValue.ToString();
                factura.Cantidad = Convert.ToInt32(txtCantidad.Text);
                factura.Punitario = Convert.ToDouble(txtPrecio.Text);
                factura.Importe = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                a.insertardfactura(factura);
//                              *******SUMATORIAS******
                total += imp;
                txtSumt.Text = total.ToString();
                txtIgv.Text = (0.18 * total).ToString();
                txtNpago.Text = (1.18 * total).ToString();
                dgvCompras.DataSource = a.visualizar(Convert.ToInt32(txtNfact.Text));*/
            }

        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
           // txtPrecio.Text = a.obtenerprecio(cmbProductos.Text);
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            //cmbProductos.DataSource = listarProductos();
            //dgvCompras.DataSource = a.visualizar(0);
            dtFecha.Text = DateTime.Now.ToString();
            dgvCompras.Columns[0].HeaderText = "NºFactura";
            dgvCompras.Columns[1].HeaderText = "Código";
            dgvCompras.Columns[2].HeaderText = "Producto";
            dgvCompras.Columns[3].HeaderText = "Cantidad";
            dgvCompras.Columns[4].HeaderText = "P_unitario";
            dgvCompras.Columns[5].HeaderText = "S_total";
            dgvCompras.Columns[0].Width = 80;
            dgvCompras.Columns[1].Width = 101;
            dgvCompras.Columns[2].Width = 390;
            dgvCompras.Columns[3].Width = 115;
            dgvCompras.Columns[4].Width = 115;
            dgvCompras.Columns[5].Width = 115;

        }

        private void btnGestionarv_Click(object sender, EventArgs e)
        {
            if (txtNpago.Text.Length > 0)
            {
                /*using (HERRAMIENTAS_FINALEntities2 bd = new HERRAMIENTAS_FINALEntities2())
                {
                    Factura fact = new Factura();
                    fact.NFAC = Convert.ToInt32(txtNfact.Text.Trim());
                    fact.DNI = txtCodc.Text.Trim();
                    fact.FECHA = Convert.ToDateTime(dtFecha.Text.Trim());
                    fact.STOTAL = Convert.ToDouble(txtSumt.Text.Trim());
                    fact.IGV = Convert.ToDouble(txtIgv.Text.Trim());
                    fact.TOTAL = Convert.ToDouble(txtNpago.Text.Trim());
                    bd.Factura.Add(fact);
                    bd.SaveChanges();
                }*/
                MessageBox.Show("Registrado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                total = 0;
            }
            else
            {
                MessageBox.Show("Debe registrar datos primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
           /* if (txtNfact.Text.Length > 0)
            {
                dgvCompras.DataSource = a.visualizar(Convert.ToInt32(txtNfact.Text));
            }
            else
            {
                dgvCompras.DataSource = a.visualizar(0);
            }*/
        }
    }
}
