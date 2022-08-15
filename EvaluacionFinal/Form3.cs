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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //====================================== LIMPIAR FORMULARIO =======================================
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
        }
        //================================================================================================== 



        private void dgvProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodp.ReadOnly = true;
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvProv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvProv.CurrentRow.Selected = true;
                txtCodp.Text = dgvProv.Rows[e.RowIndex].Cells["CODP"].FormattedValue.ToString();
                txtDatos.Text = dgvProv.Rows[e.RowIndex].Cells["DATPRO"].FormattedValue.ToString();
                txtDireccion.Text = dgvProv.Rows[e.RowIndex].Cells["DIRPRO"].FormattedValue.ToString();

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //================== INSTACIAMOS LA CLASE PROVEEDOR Y LLAMAR A LA FUNCIÓN INGRESAR PROVEEDOR ===============
            ClsProveedor oClsProveedor = new ClsProveedor();
            if (oClsProveedor.validarCodigoProveedorRepetido(txtCodp.Text) > 0)
            {
                MessageBox.Show("Codigo de proveedor ya existe");
            }
            else
            {
                oClsProveedor.ingresarProveedor(txtCodp.Text, txtDatos.Text, txtDireccion.Text);
                limpiar();
                dgvProv.DataSource = oClsProveedor.ListarProveedores();
                //===========================================================================================================
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //================== INSTACIAMOS LA CLASE PROVEEDOR Y LLAMAR A LA FUNCIÓN MODIFICAR PROVEEDOR ===============
            ClsProveedor oClsProveedor = new ClsProveedor();
            oClsProveedor.modificarProveedor(txtCodp.Text, txtDatos.Text, txtDireccion.Text);
            limpiar();
            dgvProv.DataSource = oClsProveedor.ListarProveedores();
            //===========================================================================================================
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
                dgvProv.DataSource = oClsProveedor.ListarProveedores();
            }
        }



        private void frmProveedor_Load(object sender, EventArgs e)
        {
            ClsProveedor oClsProveedor = new ClsProveedor();
            dgvProv.DataSource = oClsProveedor.ListarProveedores();
        }

        private void txtDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccion.Focus();
            }
            ClsValidaciones.validarLetras(e);
        }
    }
}
