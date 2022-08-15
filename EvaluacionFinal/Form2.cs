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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool validar()
        {
            bool valido = false;
            if (txtUser.Text.Length > 0 && txtPass.Text.Length > 0)
                valido = true;
            return valido;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                using (HERRAMIENTAS_FINALEntities1 bd = new HERRAMIENTAS_FINALEntities1())//instanciando la base de datos
                {
                    foreach (Usuario u in bd.Usuario.ToList())
                    {
                        if (txtUser.Text.Trim() == u.nombre && txtPass.Text.Trim() == u.clave)
                        {
                            frmMenu menu = new frmMenu();
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o contraseña incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se permiten campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
