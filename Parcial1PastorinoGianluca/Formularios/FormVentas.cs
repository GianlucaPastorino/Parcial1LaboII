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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            ActualizarVentas();
            if(!((FormPrincipal)Owner).usuarioLogueado.EsAdmin)
            {
                this.BackColor = Color.FromArgb(32, 30, 75);
            }
        }

        private void ActualizarVentas()
        {
            dgvVentas.Rows.Clear();
            foreach (Pedido venta in Bar.Ventas)
            {
                if (txbBuscar.Text is not null)
                {
                    if (venta.Vendedor.Nombre.ToLower().Contains(txbBuscar.Text.ToLower()))
                    {
                        AgregarVenta(venta);
                    }
                }
                else
                {
                    AgregarVenta(venta);
                }
            }
            lblSumaTotal.Text = "$ " + Bar.CalcularTotalVentas().ToString();
        }

        private void AgregarVenta(Pedido venta)
        {
            dgvVentas.Rows.Add(venta.FechaYhora.ToString(), venta.Vendedor.Nombre, venta.ToString(),
                    venta.Estacionamiento ? "Sí" : "No", venta.MedioDePago.ToString(), venta.Total);
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

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarVentas();
        }

        private void txbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ActualizarVentas();
        }
    }
}
