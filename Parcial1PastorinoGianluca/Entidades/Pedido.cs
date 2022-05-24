using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public enum EMedioDePago
        {
            Efectivo, Débito, Crédito, QR
        }

        Usuario vendedor;
        bool estacionamiento;
        Dictionary<Producto, int> consumiciones;
        float total;
        DateTime fechaYhora;
        EMedioDePago medioDePago;

        public Dictionary<Producto, int> Consumiciones
        {
            get => consumiciones;
        }

        public float Total
        {
            get => total;
            set => total = value;
        }
        public DateTime FechaYhora
        {
            get => fechaYhora;
            set => fechaYhora = value;
        }

        public Usuario Vendedor
        {
            get => vendedor;
        }
        public bool Estacionamiento
        {
            get => estacionamiento;
        }
        public EMedioDePago MedioDePago
        {
            get => medioDePago;
        }

        private Pedido()
        {
            consumiciones = new Dictionary<Producto, int>();
        }

        public Pedido(Usuario vendedor) : this()
        {
            this.vendedor = vendedor;
        }

        internal Pedido(Usuario vendedor, Dictionary<Producto, int> consumiciones, DateTime fechaYhora,
            bool estacionamiento, EMedioDePago medioDePago) :this(vendedor)
        {
            this.consumiciones = consumiciones;
            this.fechaYhora = fechaYhora;
            this.estacionamiento = estacionamiento;
            this.medioDePago = medioDePago;
            this.total = CalcularTotal(estacionamiento, medioDePago);
        }

        public bool AgregarConsumicion(Producto producto, int cantidad)
        {
            int reemplazanteValue = 0;
            bool existente = false;

            if (Producto.ConsultarDisponibilidadDeStock(Bar.Productos, producto, cantidad))
            {
                foreach (KeyValuePair<Producto, int> item in consumiciones)
                {
                    if (item.Key == producto)
                    {
                        reemplazanteValue = item.Value + cantidad;
                        existente = true;
                        break;
                    }
                }
                if (existente)
                {
                    consumiciones.Remove(producto);
                    consumiciones.Add(producto, reemplazanteValue);
                    producto -= cantidad;
                    return true;
                }
                else
                {
                    consumiciones.Add(producto, cantidad);
                    producto -= cantidad;
                    return true;
                }
            }

            return false;
        }

        public bool EditarConsumicion(Producto producto, string strCantidad)
        {
            if (int.TryParse(strCantidad, out int cantidad))
            {
                foreach (KeyValuePair<Producto, int> item in consumiciones)
                {
                    if (item.Key == producto)
                    {
                        if (cantidad < item.Value && cantidad > 0)
                        {
                            producto += (item.Value - cantidad);
                            consumiciones.Remove(producto);
                            consumiciones.Add(producto, cantidad);
                            return true;
                        }

                        if (cantidad > item.Value && (cantidad - item.Value) <= item.Key.Stock)
                        {
                            producto -= (cantidad - item.Value);
                            consumiciones.Remove(producto);
                            consumiciones.Add(producto, cantidad);
                            return true;
                        }

                        if (cantidad == 0)
                        {
                            producto += item.Value;
                            consumiciones.Remove(producto);
                            return true;
                        }

                        return false;
                    }
                }
            }

            return false;
        }

        public float CalcularTotalParcial()
        {
            float totalParcial = 0;

            foreach (KeyValuePair<Producto, int> producto in this.consumiciones)
            {
                totalParcial += producto.Key.Precio * producto.Value;
            }

            return totalParcial;
        }

        public float CalcularTotal(bool estacionamiento, EMedioDePago medioDePago)
        {
            float retorno = CalcularTotalParcial();

            this.estacionamiento = estacionamiento;
            this.medioDePago = medioDePago;

            if (this.estacionamiento == true)
            {
                retorno += 500;
            }

            if (this.medioDePago == EMedioDePago.Crédito)
            {
                retorno *= 1.1f;
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<Producto, int> item in consumiciones)
            {
                sb.AppendLine($"{item.Key.Mostrar()} ${item.Key.Precio} x {item.Value}u. = ${item.Key.Precio * item.Value}");
            }

            return sb.ToString();
        }
    }
}
