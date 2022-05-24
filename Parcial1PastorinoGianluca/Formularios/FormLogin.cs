using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            Usuario usuarioAloguear = Bar.validarLogin(txbUsuario.Text, txbContraseña.Text);

            if (usuarioAloguear is not null)
            {
                FormPrincipal frmPrincipal = new FormPrincipal(usuarioAloguear);
                frmPrincipal.Show();
                this.Hide();
            }
        }
        
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txbUsuario.Text = "40936456";
            txbContraseña.Text = "ElCreador";
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            txbUsuario.Text = "33016244";
            txbContraseña.Text = "AnkaraMessi";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
