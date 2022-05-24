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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            ActualizarInventario();
            if (!((FormPrincipal)Owner).usuarioLogueado.EsAdmin)
            {
                btnAgregar.Hide();
                btnEditarStock.Hide();
                dgvInventario.Columns[2].ReadOnly = true;
                this.BackColor = Color.FromArgb(32, 30, 75);
            }
        }

        private void ActualizarColor()
        {
            foreach (DataGridViewRow fila in dgvInventario.Rows)
            {
                if (int.TryParse(fila.Cells[3].Value.ToString(), out int cantidad))
                {
                    if (cantidad <= 50 && cantidad > 25)
                    {
                        fila.DefaultCellStyle.BackColor = Color.Tomato;
                    }
                    else if (cantidad <= 25 && cantidad > 0)
                    {
                        fila.DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                    else if (cantidad == 0)
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void AgregarProducto(Producto producto)
        {
            if (producto is Comida comida)
            {
                dgvInventario.Rows.Add(producto.IdProducto, producto.Mostrar(), "Comida - " + comida.Tipo.ToString(), producto.Stock);
            }
            if (producto is Bebida bebida)
            {
                dgvInventario.Rows.Add(producto.IdProducto, producto.Mostrar(), "Bebida - " + bebida.Tipo.ToString(), producto.Stock);
            }
        }

        private void ActualizarInventario()
        {
            dgvInventario.Rows.Clear();
            foreach (Producto item in Bar.Productos)
            {
                if(txbBuscar.Text is not null)
                {
                    if (item.Nombre.ToLower().Contains(txbBuscar.Text.ToLower()))
                    {
                        AgregarProducto(item);
                    }
                }
                else
                {
                    AgregarProducto(item);
                }
            }
            ActualizarColor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarProducto frmNuevoProducto = new FormAgregarProducto();
            frmNuevoProducto.ShowDialog();
            if (frmNuevoProducto.DialogResult == DialogResult.OK)
            {
                ActualizarInventario();
                ((FormPrincipal)Owner).ActualizarMenu();
            }
        }

        private void btnEditarStock_Click(object sender, EventArgs e)
        {
            Producto auxProducto = Producto.BuscarProductoPorId(Bar.Productos, dgvInventario.CurrentRow.Cells[0].Value.ToString());
            FormAgregarStock frmAgregar = new FormAgregarStock(auxProducto);
            frmAgregar.ShowDialog();
            if (frmAgregar.DialogResult == DialogResult.Yes)
            {
                ActualizarInventario();
                ((FormPrincipal)Owner).ActualizarMenu();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormPrincipal.CerrarAplicacion();
        }

        DataGridViewCell celdaEnEdicion;
        DataGridViewRow rowEnEdicion;
        string valorActual;

        private void dgvInventario_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            celdaEnEdicion = dgvInventario.CurrentCell;
            rowEnEdicion = dgvInventario.CurrentRow;
            valorActual = dgvInventario.CurrentCell.Value.ToString();
        }

        private void dgvInventario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (celdaEnEdicion.Value is not null)
            {
                if (valorActual != celdaEnEdicion.Value.ToString() && int.TryParse(celdaEnEdicion.Value.ToString(), out int cantidad))
                {
                    Producto auxProducto = Producto.BuscarProductoPorId(Bar.Productos, rowEnEdicion.Cells[0].Value.ToString());
                    if (MessageBox.Show($"¿Seguro que desea reemplazar el stock de {auxProducto.Mostrar()} por {cantidad} unidades?", "Confirmar",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        auxProducto.Stock = cantidad;
                        ((FormPrincipal)Owner).ActualizarMenu();
                    }
                }
            }
        }

        private void dgvInventario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarInventario();
        }

        private void txbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ActualizarInventario();
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarInventario();
        }
    }
}
