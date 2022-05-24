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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            foreach (Usuario usuario in Bar.Usuarios)
            {
                if(!usuario.EsAdmin)
                {
                    dgvEmpleados.Rows.Add(usuario.Dni, usuario.Nombre);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormPrincipal.CerrarAplicacion();
        }
    }
}
