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
    public partial class FormAgregarStock : Form
    {
        Producto producto;
        public FormAgregarStock(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void FormAgregarStock_Load(object sender, EventArgs e)
        {
            lblNombreProducto.Text = producto.Mostrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbUnidades.Text, out int cantidad) && cantidad > 0)
            {
                if (MessageBox.Show($"¿Seguro que desea agregar {cantidad} unidades de {producto.Mostrar()}?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    producto += cantidad;
                    DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                MessageBox.Show("Debe agregar una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbUnidades.Clear();
            }
        }
    }
}
