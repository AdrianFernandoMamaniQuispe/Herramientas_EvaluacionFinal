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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        clsCliente cli = new clsCliente();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool FormularioValido()
        {
            bool valido = false;

            string dni = txtDni.Text.Trim();
            string nombre = txtNombres.Text.ToUpper().Trim();
            string direccion = txtDireccion.Text.ToUpper().Trim();
            string telefono = txtTelef.Text.ToUpper().Trim();



            if (dni.Length > 0 && nombre.Length > 0 && telefono.Length > 0 && direccion.Length > 0)
            { valido = true; }

            else
            {
                //VALIDA VACIOS
                MessageBox.Show("Todos los datos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
            }


            return valido;
        }

        private Boolean validarCodigo() //VALIDA SI EL CODIGO A REGISTRAR NO EXISTE
        {
            using (HERRAMIENTAS_EX_FINALEntities bd = new HERRAMIENTAS_EX_FINALEntities())//instanciando la base de datos
            {
                foreach (Cliente cli in bd.Cliente.ToList())
                {
                    if (txtDni.Text.Trim() == Convert.ToString(cli.DNI))
                    //compara si el codigo ya existe 

                    {
                        return false;
                        //si es asi que retorne falso
                    }
                }
                return true;
            }
        }


        public void limpiar()
        {
            foreach (Control caja in this.Controls)
            {
                if (caja is TextBox)
                {
                    caja.Text = "";
                }
            }
            txtDni.Focus();
        }

        public void guardar()
        {

            if (FormularioValido())
            {
                if (validarCodigo())//VALIDA QUE EL CODIGO NO ESTE REGISTRADO
                {

                    string dni = txtDni.Text.Trim();
                    string nombre = txtNombres.Text.ToUpper().Trim();
                    string telefono = txtTelef.Text.ToUpper().Trim();
                    string direccion = txtDireccion.Text.ToUpper().Trim();

                    cli.InsertarCliente(dni, nombre, direccion, telefono);
                    MessageBox.Show("Datos guardados satisfactoriamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El DNI no se puede repetir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtDni.Focus();
                dgvCliente.DataSource = cli.obtenerCliente("");

            }

        }

        private Boolean validarEliminacion()
        {
            using (HERRAMIENTAS_EX_FINALEntities bd = new HERRAMIENTAS_EX_FINALEntities())
            {
                foreach (Factura fact in bd.Factura.ToList())
                {
                    if (txtDni.Text == Convert.ToString(fact.DNI))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = cli.obtenerCliente("");
            dgvCliente.Columns[0].HeaderText = "DNI";
            dgvCliente.Columns[1].HeaderText = "NOMBRE";
            dgvCliente.Columns[2].HeaderText = "DIRECCION";
            dgvCliente.Columns[3].HeaderText = "TELEFONO";
            dgvCliente.Columns[0].Width = 100;
            dgvCliente.Columns[1].Width = 160;
            dgvCliente.Columns[2].Width = 180;
            dgvCliente.Columns[3].Width = 100;
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvCliente.CurrentRow.Selected = true;

                txtDni.Text = dgvCliente.Rows[e.RowIndex].Cells["dni"].FormattedValue.ToString();
                txtNombres.Text = dgvCliente.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
                txtDireccion.Text = dgvCliente.Rows[e.RowIndex].Cells["direccion"].FormattedValue.ToString();
                txtTelef.Text = dgvCliente.Rows[e.RowIndex].Cells["telefono"].FormattedValue.ToString();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Trim().Length > 0)
            {

                if (FormularioValido())
                {
                    string dni = txtDni.Text.Trim();
                    string nombre = txtNombres.Text.ToUpper().Trim();
                    string telefono = txtTelef.Text.ToUpper().Trim();
                    string direccion = txtDireccion.Text.ToUpper().Trim();

                    cli.modificarCliente(dni, nombre, direccion, telefono);
                    dgvCliente.DataSource = cli.obtenerCliente("");
                    MessageBox.Show("Datos modificados", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro que desea modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarEliminacion())
            {
                if (txtDni.Text.Trim().Length > 0)
                {
                    DialogResult respuestaAdvertencia = DialogResult.OK;
                    respuestaAdvertencia = MessageBox.Show("¿Está seguro de eliminar al profesor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuestaAdvertencia == DialogResult.Yes)
                    {
                        cli.eliminarCliente(txtDni.Text);
                        dgvCliente.DataSource = cli.obtenerCliente("");
                        limpiar();
                        MessageBox.Show("Registro eliminado satisfactoriamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el registro que desea eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tablas relacionadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombres.Focus();
            }
            Validaciones.validarNumeros(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccion.Focus();
            }
            Validaciones.validarLetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelef.Focus();
            }
        }

        private void txtTelef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
            }
            Validaciones.validarNumeros(e);
        }
    }
}
