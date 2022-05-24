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
    public partial class FormCobrar : Form
    {
        Pedido pedido;

        public FormCobrar(Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
        }

        private void FormCobrar_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Pedido.EMedioDePago)))
            {
                cboMedioDePago.Items.Add(item);
            }
            cboMedioDePago.SelectedIndex = 0;

            lblPrecioFinal.Text = "$" + pedido.CalcularTotalParcial().ToString();
        }

        private void cbEstacionamiento_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void cboMedioDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            lblPrecioFinal.Text = "$" + pedido.CalcularTotal(cbEstacionamiento.Checked, (Pedido.EMedioDePago)cboMedioDePago.SelectedItem).ToString();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            DialogResult cobrar = MessageBox.Show("¿Está seguro de cobrar éste pedido?", "Cobrar",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cobrar == DialogResult.Yes)
            {
                pedido.Total = pedido.CalcularTotal(cbEstacionamiento.Checked, (Pedido.EMedioDePago)cboMedioDePago.SelectedItem);
                pedido.FechaYhora = DateTime.Now;
                Bar.Ventas.Add(pedido);
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
