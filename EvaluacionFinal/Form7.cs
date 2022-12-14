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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        private List<OBTENER_PRODUCTOS_Result> visualizar()
        {
            try
            {
                using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
                {
                    var consulta = bd.OBTENER_PRODUCTOS().ToList();
                    return consulta;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = visualizar();
        }
        private bool FormularioValido()
        {
            bool valido = false;

            string codigo = txtCodprod.Text;
            string nombre = txtDescripcion.Text;
            string precio = txtPrecio.Text;
            string stock = txtStock.Text;

            if (codigo.Length > 0 && nombre.Length > 0 && precio.Length > 0 && stock.Length > 0)
                valido = true;
            return valido;
        }
        public void guardar()
        {
            if (FormularioValido())
            {
                using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
                {
                    Producto producto = new Producto();
                    producto.Codpro = txtCodprod.Text;
                    producto.Descripcion = txtDescripcion.Text;
                    producto.Precio = Convert.ToDouble(txtPrecio.Text);
                    producto.Stock = Convert.ToInt32(txtStock.Text);
                    bd.Producto.Add(producto);
                    bd.SaveChanges();
                }
                dgvProductos.DataSource = visualizar();
                MessageBox.Show("Datos guardados satisfactoriamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Todos los datos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void modificar()
        {
            if (FormularioValido())
            {
                using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
                {
                    Producto producto = new Producto();
                    producto.Codpro = txtCodprod.Text;
                    producto.Descripcion = txtDescripcion.Text;
                    producto.Precio = Convert.ToDouble(txtPrecio.Text);
                    producto.Stock = Convert.ToInt32(txtStock.Text);
                    bd.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
                dgvProductos.DataSource = visualizar();
                MessageBox.Show("Datos modificados satisfactoriamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Todos los datos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarRegistro())
            {
                guardar();
                limpiar();
            }
            else
            {
                MessageBox.Show("Registro existente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvProductos.CurrentRow.Selected = true;
                txtCodprod.Text = dgvProductos.Rows[e.RowIndex].Cells["Codpro"].FormattedValue.ToString();
                txtDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells["Precio"].FormattedValue.ToString();
                txtStock.Text = dgvProductos.Rows[e.RowIndex].Cells["Stock"].FormattedValue.ToString();
            }
        }

        private void limpiar()
        {
            foreach (Control caja in this.Controls)
            {
                if (caja is TextBox)
                {
                    caja.Text = "";
                }
            }
            txtCodprod.Focus();
        }
        private Boolean validarRegistro()
        {
            using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
            {
                foreach (Producto prod in bd.Producto.ToList())
                {
                    if (txtCodprod.Text == prod.Codpro)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        private Boolean validarEliminacion()
        {
            using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
            {
                foreach (DetalleCompra dcompra in bd.DetalleCompra.ToList())
                {
                    if (txtCodprod.Text == dcompra.Codpro)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        private void eliminar()
        {
            using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())
            {
                Producto area = bd.Producto.Find(txtCodprod.Text);
                bd.Producto.Remove(area);
                bd.SaveChanges();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarEliminacion())
            {
                eliminar();
                limpiar();
                MessageBox.Show("Registro eliminado");
                dgvProductos.DataSource = visualizar();
            }
            else
            {
                MessageBox.Show("Tablas relacionadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
