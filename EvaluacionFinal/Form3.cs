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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";
                }
            }
            txtCodp.ReadOnly = false;
            txtCodp.Focus();
            //═════════════════════════════════════════CAMBIO═════════════════════════════════════════════╗
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            //════════════════════════════════════════════════════════════════════════════════════════════╝
        }

        //═════════════════════════════════════════CAMBIO═════════════════════════════════════════════╗
        private void mostrarListaProveedores()
        {
            ClsProveedor oClsProveedor = new ClsProveedor();
            dgvProv.DataSource = oClsProveedor.ListarProveedores();
            dgvProv.Columns[0].HeaderText = "Código Proveedor";
            dgvProv.Columns[1].HeaderText = "Nombres completos";
            dgvProv.Columns[2].HeaderText = "Dirección";
            dgvProv.Columns[0].Width = 100;
            dgvProv.Columns[1].Width = 186;
            dgvProv.Columns[2].Width = 240;

        }
        //════════════════════════════════════════════════════════════════════════════════════════════╝

        //═════════════════════════════════════════CAMBIO═════════════════════════════════════════════╗
        private bool formularioValido()
        {
            bool valido = false;

            string pcodigo = txtCodp.Text;
            string pnombres = txtDatos.Text;
            string pdireccion = txtDireccion.Text;

            if (pcodigo.Length > 0 && pnombres.Length > 0 && pdireccion.Length > 0)
            {
                valido = true;
            }
            return valido;
        }
        //════════════════════════════════════════════════════════════════════════════════════════════╝



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            //═════════════════════════════════════════CAMBIO═════════════════════════════════════════════╗
            mostrarListaProveedores();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            //════════════════════════════════════════════════════════════════════════════════════════════╝
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsProveedor oClsProveedor = new ClsProveedor();
            if (oClsProveedor.validarCodigoProveedorRelaciado(txtCodp.Text) > 0)
            {
                MessageBox.Show("El proveedor se encuentra relacionado");
            }
            else
            {
                oClsProveedor.eliminar(txtCodp.Text);
                limpiar();
                mostrarListaProveedores();
                //═════════════════════════════════════════CAMBIO═════════════════════════════════════════════╗
                MessageBox.Show("Proveedor eliminado");
                //════════════════════════════════════════════════════════════════════════════════════════════╝
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //═════════════════════════════════════════CAMBIO═════════════════════════════════════════════╗
            ClsProveedor oClsProveedor = new ClsProveedor();
            if (formularioValido())
            {
                //================== INSTACIAMOS LA CLASE PROVEEDOR Y LLAMAR A LA FUNCIÓN MODIFICAR PROVEEDOR ===============
                oClsProveedor.modificarProveedor(txtCodp.Text, txtDatos.Text, txtDireccion.Text);
                limpiar();
                mostrarListaProveedores();

                MessageBox.Show("Modificación realizada");


                //===========================================================================================================

            }
            else
            {
                MessageBox.Show("No se permite datos vacios");
            }
            //════════════════════════════════════════════════════════════════════════════════════════════╝
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //═════════════════════════════════════════════════════════════════CAMBIO═════════════════════════════════════════════════════╗

            //================== INSTACIAMOS LA CLASE PROVEEDOR Y LLAMAR A LA FUNCIÓN INGRESAR PROVEEDOR ===============
            ClsProveedor oClsProveedor = new ClsProveedor();
            if (formularioValido())
            {
                if (oClsProveedor.validarCodigoProveedorRepetido(txtCodp.Text) > 0)
                {
                    MessageBox.Show("Codigo de proveedor ya existe");
                    txtCodp.Focus();
                }
                else
                {
                    oClsProveedor.ingresarProveedor(txtCodp.Text, txtDatos.Text, txtDireccion.Text);
                    limpiar();
                    mostrarListaProveedores();

                    MessageBox.Show("Proveedor guardado");


                    //===========================================================================================================
                }
            }
            else
            {
                MessageBox.Show("No se permite datos vacios");
            }
            //════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //═════════════════════════════════════════CAMBIO═════════════════════════════════════════════╗
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            //════════════════════════════════════════════════════════════════════════════════════════════╝
            txtCodp.ReadOnly = true;
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvProv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvProv.CurrentRow.Selected = true;
                txtCodp.Text = dgvProv.Rows[e.RowIndex].Cells["CODP"].FormattedValue.ToString();
                txtDatos.Text = dgvProv.Rows[e.RowIndex].Cells["DATPRO"].FormattedValue.ToString();
                txtDireccion.Text = dgvProv.Rows[e.RowIndex].Cells["DIRPRO"].FormattedValue.ToString();

            }
        }

        private void txtDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccion.Focus();
            }
            Validaciones.validarLetras(e);
        }

        private void txtCodp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //═════════════════════════════════════════CAMBIO═════════════════════════════════════════════╗
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDatos.Focus();
            }
            //════════════════════════════════════════════════════════════════════════════════════════════╝
        }
    }
}
