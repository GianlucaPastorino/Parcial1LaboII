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
    public partial class FormPrincipal : Form
    {
        internal Usuario usuarioLogueado;
        List<Button> botones;
        Sector ubicacionActual;

        private FormPrincipal()
        {
            InitializeComponent();
            botones = new List<Button>();
            CargarMesas();
        }

        public FormPrincipal(Usuario user) : this()
        {
            usuarioLogueado = user;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarUbicaciones();
            cboFiltrar1.SelectedIndex = 0;
            ActualizarMenu();
            if (!usuarioLogueado.EsAdmin)
            {
                btnEmpleados.Hide();
                this.BackColor = Color.FromArgb(32, 30, 75);
            }
            cboCantidad.SelectedIndex = 0;

            lblNombre.Text = usuarioLogueado.Nombre;
        }

        private void CargarMesas()
        {
            botones.Add(btnMesa1);
            botones.Add(btnMesa2);
            botones.Add(btnMesa3);
            botones.Add(btnMesa4);
            botones.Add(btnMesa5);
            botones.Add(btnMesa6);
            botones.Add(btnMesa7);
            botones.Add(btnMesa8);
            botones.Add(btnMesa9);
            botones.Add(btnMesa10);
            botones.Add(btnMesa11);
            botones.Add(btnMesa12);
            botones.Add(btnMesa13);
            botones.Add(btnMesa14);
            botones.Add(btnMesa15);
            botones.Add(btnBarra16);
            botones.Add(btnBarra17);
            botones.Add(btnBarra18);
            botones.Add(btnBarra19);
            botones.Add(btnBarra20);
        }

        internal void ActualizarMenu()
        {
            dtgvProductos.Rows.Clear();
            foreach (Producto item in Bar.Productos)
            {
                if (item.Stock > 0)
                {
                    switch (cboFiltrar1.Text)
                    {
                        case "Todo":
                            dtgvProductos.Rows.Add(item.IdProducto, item.Mostrar(), item.Precio);
                            break;
                        case "Comida":
                            if (item is Comida comida)
                            {
                                switch (cboFiltrar2.Text)
                                {
                                    case "Entradas":
                                        if (comida.Tipo == Comida.ETipo.Entrada)
                                        {
                                            dtgvProductos.Rows.Add(item.IdProducto, comida.Mostrar(), comida.Precio);
                                        }
                                        break;
                                    case "Hamburguesas":
                                        if (comida.Tipo == Comida.ETipo.Hamburguesa)
                                        {
                                            dtgvProductos.Rows.Add(item.IdProducto, comida.Mostrar(), comida.Precio);
                                        }
                                        break;
                                    case "Postres":
                                        if (comida.Tipo == Comida.ETipo.Postre)
                                        {
                                            dtgvProductos.Rows.Add(item.IdProducto, comida.Mostrar(), comida.Precio);
                                        }
                                        break;
                                    case "Otras":
                                        if (comida.Tipo == Comida.ETipo.Otro)
                                        {
                                            dtgvProductos.Rows.Add(item.IdProducto, comida.Mostrar(), comida.Precio);
                                        }
                                        break;
                                    default:
                                        dtgvProductos.Rows.Add(item.IdProducto, comida.Mostrar(), comida.Precio);
                                        break;
                                }
                            }
                            break;
                        case "Bebida":
                            if (item is Bebida bebida)
                            {
                                switch (cboFiltrar2.Text)
                                {
                                    case "Cervezas":
                                        if (bebida.Tipo == Bebida.ETipo.Cerveza)
                                        {
                                            dtgvProductos.Rows.Add(item.IdProducto, bebida.Mostrar(), bebida.Precio);
                                        }
                                        break;
                                    case "Tragos":
                                        if (bebida.Tipo == Bebida.ETipo.Trago)
                                        {
                                            dtgvProductos.Rows.Add(item.IdProducto, bebida.Mostrar(), bebida.Precio);
                                        }
                                        break;
                                    case "Gaseosas":
                                        if (bebida.Tipo == Bebida.ETipo.Gaseosa)
                                        {
                                            dtgvProductos.Rows.Add(item.IdProducto, bebida.Mostrar(), bebida.Precio);
                                        }
                                        break;
                                    case "Aguas":
                                        if (bebida.Tipo == Bebida.ETipo.Agua)
                                        {
                                            dtgvProductos.Rows.Add(item.IdProducto, bebida.Mostrar(), bebida.Precio);
                                        }
                                        break;
                                    case "Otras":
                                        if (bebida.Tipo == Bebida.ETipo.Otro)
                                        {
                                            dtgvProductos.Rows.Add(item.IdProducto, bebida.Mostrar(), bebida.Precio);
                                        }
                                        break;
                                    default:
                                        dtgvProductos.Rows.Add(item.IdProducto, bebida.Mostrar(), bebida.Precio);
                                        break;
                                }
                            }
                            break;
                    }
                }
            }
        }
        private void ActualizarPedido()
        {
            dtgvPedido.Rows.Clear();
            if (!ubicacionActual.EstaLibre)
            {
                dtgvPedido.Enabled = true;
                foreach (KeyValuePair<Producto, int> item in ubicacionActual.PedidoActual.Consumiciones)
                {
                    dtgvPedido.Rows.Add(item.Key.IdProducto, item.Key.Mostrar(), item.Value, item.Key.Precio * item.Value);
                }

                if (ubicacionActual.PedidoActual.Total > 0)
                {
                    lblPrecioTotal.Text = "$" + ubicacionActual.PedidoActual.Total;
                    lblPrecioTotal.ForeColor = Color.Green;
                }
                else
                {
                    lblPrecioTotal.Text = "$" + ubicacionActual.PedidoActual.CalcularTotalParcial().ToString();
                    lblPrecioTotal.ForeColor = Color.Gainsboro;
                }
            }
            else
            {
                dtgvPedido.Enabled = false;
                lblPrecioTotal.Text = "$0";
                lblPrecioTotal.ForeColor = Color.Gainsboro;
            }
        }

        private void ActualizarUbicaciones()
        {
            foreach (Sector item in Bar.Ubicaciones)
            {
                int indice = Array.IndexOf(Bar.Ubicaciones, item);

                if (item.EstaLibre == true)
                {
                    botones[indice].BackColor = Color.Green;
                }
                else
                {
                    botones[indice].BackColor = Color.Red;
                }
            }
        }

        private void ActualizarBtnsOcuparLiberarAgregar()
        {
            int numero = Array.IndexOf(Bar.Ubicaciones, ubicacionActual) + 1;

            if (ubicacionActual.EstaLibre)
            {
                btnOcuparLiberar.Text = $"Ocupar {ubicacionActual.Tipo} {numero}";
                btnAgregar.Enabled = false;
                cboCantidad.Enabled = false;
            }
            else
            {
                if (ubicacionActual.PedidoActual.Consumiciones.Count > 0 && ubicacionActual.PedidoActual.Total == 0)
                {
                    btnOcuparLiberar.Text = $"Cobrar {ubicacionActual.Tipo} {numero}";
                    btnAgregar.Enabled = true;
                    cboCantidad.Enabled = true;
                }
                else
                {
                    btnOcuparLiberar.Text = $"Liberar {ubicacionActual.Tipo} {numero}";
                    btnAgregar.Enabled = true;
                    cboCantidad.Enabled = true;

                    if (ubicacionActual.PedidoActual.Total > 0)
                    {
                        btnAgregar.Enabled = false;
                        cboCantidad.Enabled = false;
                    }
                }
            }
        }

        private bool AgregarAPedido(int cantidad)
        {
            bool retorno = false;

            if (ubicacionActual is not null && !ubicacionActual.EstaLibre && ubicacionActual.PedidoActual.Total == 0)
            {
                Producto auxProducto = Producto.BuscarProductoPorId(Bar.Productos, dtgvProductos.CurrentRow.Cells[0].Value.ToString());
                retorno = ubicacionActual.PedidoActual.AgregarConsumicion(auxProducto, cantidad);

                if (auxProducto.Stock == 0)
                {
                    ActualizarMenu();
                }
                ActualizarPedido();
                ActualizarBtnsOcuparLiberarAgregar();
            }

            return retorno;
        }

        private static DialogResult DeseaEliminar()
        {
            return MessageBox.Show("¿Desea eliminar este producto del pedido?", "Eliminar",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        internal static void CerrarAplicacion()
        {
            if (MessageBox.Show("¿Seguro que desea cerrar el programa?", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cboFiltrar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarMenu();
            switch (cboFiltrar1.SelectedIndex)
            {
                case 0:
                    {
                        cboFiltrar2.SelectedIndex = -1;
                        cboFiltrar2.Enabled = false;
                    }
                    break;
                case 1:
                    cboFiltrar2.Items.Clear();
                    cboFiltrar2.Items.Add("Todas");
                    cboFiltrar2.Items.Add("Entradas");
                    cboFiltrar2.Items.Add("Hamburguesas");
                    cboFiltrar2.Items.Add("Postres");
                    cboFiltrar2.Items.Add("Otras");
                    cboFiltrar2.SelectedIndex = 0;
                    cboFiltrar2.Enabled = true;
                    break;
                case 2:
                    cboFiltrar2.Items.Clear();
                    cboFiltrar2.Items.Add("Todas");
                    cboFiltrar2.Items.Add("Cervezas");
                    cboFiltrar2.Items.Add("Tragos");
                    cboFiltrar2.Items.Add("Gaseosas");
                    cboFiltrar2.Items.Add("Aguas");
                    cboFiltrar2.Items.Add("Otras");
                    cboFiltrar2.SelectedIndex = 0;
                    cboFiltrar2.Enabled = true;
                    break;
            }
        }

        private void cboFiltrar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarMenu();
        }

        private void btn_ubicacion_Click(object sender, EventArgs e)
        {
            btnOcuparLiberar.Enabled = true;
            Sector ubicacionAnterior = ubicacionActual;
            Button btnUbicacion = (Button)sender;

            foreach (Button item in botones)
            {
                if (item == btnUbicacion)
                {
                    ubicacionActual = Bar.Ubicaciones[botones.IndexOf(item)];
                }
            }

            lblPedido.Text = "Pedido " + btnUbicacion.Text + ":";

            ActualizarBtnsOcuparLiberarAgregar();
            ActualizarPedido();

            if (ubicacionActual.Tipo == Sector.ETipo.Barra)
            {
                cboFiltrar1.SelectedIndex = 2;
                cboFiltrar1.Enabled = false;
            }
            else
            {
                cboFiltrar1.Enabled = true;
                if (ubicacionAnterior is not null && ubicacionAnterior.Tipo == Sector.ETipo.Barra)
                {
                    cboFiltrar1.SelectedIndex = 0;
                }
            }
        }

        private void btnOcuparLiberar_Click(object sender, EventArgs e)
        {
            if (btnOcuparLiberar.Text.Contains("Cobrar"))
            {
                FormCobrar frmCobrar = new FormCobrar(ubicacionActual.PedidoActual);
                frmCobrar.ShowDialog();
                if (frmCobrar.DialogResult == DialogResult.Yes)
                {
                    ActualizarPedido();
                    ActualizarBtnsOcuparLiberarAgregar();
                }
            }
            else
            {
                ubicacionActual.CambiarEstado(usuarioLogueado);
                ActualizarUbicaciones();
                ActualizarBtnsOcuparLiberarAgregar();
                ActualizarPedido();
            }
        }

        private void dtgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AgregarAPedido(1);
        }

        DataGridViewCell celdaEnEdicion;
        DataGridViewRow rowEnEdicion;

        private void dtgvPedido_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            celdaEnEdicion = dtgvPedido.CurrentCell;
            rowEnEdicion = dtgvPedido.CurrentRow;
        }

        private void dtgvPedido_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (celdaEnEdicion.Value is not null && ubicacionActual.PedidoActual.Total == 0)
            {
                Producto auxProducto = Producto.BuscarProductoPorId(Bar.Productos, rowEnEdicion.Cells[0].Value.ToString());
                if (celdaEnEdicion.Value.ToString() == "0")
                {
                    if (DeseaEliminar() == DialogResult.Yes)
                    {
                        ubicacionActual.PedidoActual.EditarConsumicion(auxProducto, celdaEnEdicion.Value.ToString());
                    }
                }
                else
                {
                    ubicacionActual.PedidoActual.EditarConsumicion(auxProducto, celdaEnEdicion.Value.ToString());
                }
            }
        }

        private void dtgvPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ubicacionActual is not null)
            {
                ActualizarPedido();
                ActualizarMenu();
                ActualizarBtnsOcuparLiberarAgregar();
            }
        }

        private void dtgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvPedido.CurrentCell.ColumnIndex is 1 && ubicacionActual.PedidoActual.Total == 0)
            {
                if (DeseaEliminar() == DialogResult.Yes)
                {
                    Producto auxProducto = Producto.BuscarProductoPorId(Bar.Productos, dtgvPedido.CurrentRow.Cells[0].Value.ToString());
                    ubicacionActual.PedidoActual.EditarConsumicion(auxProducto, "0");

                    ActualizarMenu();
                    ActualizarPedido();
                    ActualizarBtnsOcuparLiberarAgregar();
                }
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FormInventario frmInventario = new FormInventario();

            frmInventario.Show(this);
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados frmEmpleados = new FormEmpleados();

            frmEmpleados.Show(this);
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas frmVentas = new FormVentas();

            frmVentas.Show(this);
            this.Hide();
        }

        private void btnCambiarDeUsuario_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();

            frmLogin.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarAplicacion();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cboCantidad.Text, out int cantidad))
            {
                if (!AgregarAPedido(cantidad))
                {
                    MessageBox.Show("La cantidad de unidades seleccionada supera el stock disponible.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
