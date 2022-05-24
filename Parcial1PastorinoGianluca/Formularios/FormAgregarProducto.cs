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
    public partial class FormAgregarProducto : Form
    {
        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
            cboSubTipo.SelectedIndex = 0;
            cboTamaño.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txbNombre.Text.Trim().Length == 0 || txbNombre.Text.Length > 100)
            {
                MessageBox.Show("Nombre vacío o demasiado largo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((float)nudPrecio.Value == 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Producto.ETamaño tamaño;
                Comida.ETipo tipoComida = Comida.ETipo.Otro;
                Bebida.ETipo tipoBebida = Bebida.ETipo.Otro;
                bool existe = false;

                switch (cboTamaño.SelectedItem.ToString())
                {
                    case "Chico":
                    case "Simple":
                    case "1/2 Pinta":
                    case "350 ml":
                        tamaño = Producto.ETamaño.Chico;
                        break;
                    case "Mediano":
                    case "Doble":
                    case "Pinta":
                    case "500 ml":
                        tamaño = Producto.ETamaño.Mediano;
                        break;
                    case "Grande":
                    case "Triple":
                    case "Botella 1L":
                    case "1,25 lts":
                        tamaño = Producto.ETamaño.Grande;
                        break;
                    default:
                        tamaño = Producto.ETamaño.Unico;
                        break;
                }

                switch (cboSubTipo.SelectedItem.ToString())
                {
                    case "Entrada":
                        tipoComida = Comida.ETipo.Entrada;
                        break;
                    case "Hamburguesa":
                        tipoComida = Comida.ETipo.Hamburguesa;
                        break;
                    case "Postre":
                        tipoComida = Comida.ETipo.Postre;
                        break;
                    case "Cerveza":
                        tipoBebida = Bebida.ETipo.Cerveza;
                        break;
                    case "Gaseosa":
                        tipoBebida = Bebida.ETipo.Gaseosa;
                        break;
                    case "Agua":
                        tipoBebida = Bebida.ETipo.Agua;
                        break;
                    case "Trago":
                        tipoBebida = Bebida.ETipo.Trago;
                        break;
                }

                foreach (Producto producto in Bar.Productos)
                {
                    if (producto.Nombre.Trim().ToLower() == txbNombre.Text.Trim().ToLower())
                    {
                        existe = true;
                        if (MessageBox.Show("Ya existe un producto con el mismo nombre. ¿Desea agregarlo igual?", "Confirmar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (cboTipo.SelectedIndex == 0)
                            {
                                Bar.Productos.Add(new Comida(tipoComida, txbNombre.Text.Trim(), tamaño, (float)nudPrecio.Value));
                            }
                            else
                            {
                                Bar.Productos.Add(new Bebida(tipoBebida, txbNombre.Text.Trim(), tamaño, (float)nudPrecio.Value));
                            }
                            this.DialogResult = DialogResult.OK;
                            break;
                        }
                    }
                }
                if (!existe)
                {
                    if (MessageBox.Show("¿Seguro que desea agregar este producto al inventario?", "Confirmar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (cboTipo.SelectedIndex == 0)
                        {
                            Bar.Productos.Add(new Comida(tipoComida, txbNombre.Text.Trim(), tamaño, (float)nudPrecio.Value));
                        }
                        else
                        {
                            Bar.Productos.Add(new Bebida(tipoBebida, txbNombre.Text.Trim(), tamaño, (float)nudPrecio.Value));
                        }
                        this.DialogResult = DialogResult.OK;
                    }      
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSubTipo.Items.Clear();
            switch (cboTipo.SelectedIndex)
            {
                case 0: // Comida
                    cboSubTipo.Items.Add("Entrada");
                    cboSubTipo.Items.Add("Hamburguesa");
                    cboSubTipo.Items.Add("Postre");
                    cboSubTipo.Items.Add("Otro");
                    break;
                case 1: // Bebida
                    cboSubTipo.Items.Add("Cerveza");
                    cboSubTipo.Items.Add("Gaseosa");
                    cboSubTipo.Items.Add("Agua");
                    cboSubTipo.Items.Add("Trago");
                    cboSubTipo.Items.Add("Otro");
                    break;
            }
            cboSubTipo.SelectedIndex = 0;
        }

        private void cboSubTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTamaño.Items.Clear();
            switch (cboSubTipo.SelectedItem.ToString())
            {
                case "Entrada":
                case "Postre":
                    cboTamaño.Items.Add("Chico");
                    cboTamaño.Items.Add("Mediano");
                    cboTamaño.Items.Add("Grande");
                    cboTamaño.Items.Add("Único/Otro");
                    break;
                case "Hamburguesa":
                    cboTamaño.Items.Add("Simple");
                    cboTamaño.Items.Add("Doble");
                    cboTamaño.Items.Add("Triple");
                    cboTamaño.Items.Add("Otro");
                    break;
                case "Cerveza":
                    cboTamaño.Items.Add("1/2 Pinta");
                    cboTamaño.Items.Add("Pinta");
                    cboTamaño.Items.Add("Botella 1L");
                    cboTamaño.Items.Add("Otro");
                    break;
                case "Gaseosa":
                case "Agua":
                    cboTamaño.Items.Add("350 ml");
                    cboTamaño.Items.Add("500 ml");
                    cboTamaño.Items.Add("1,25 lts");
                    cboTamaño.Items.Add("Otro");
                    break;
                case "Trago":
                case "Otro":
                    cboTamaño.Items.Add("Único");
                    break;
            }
            cboTamaño.SelectedIndex = 0;
        }
    }
}
