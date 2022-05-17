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

        public Pedido(Usuario vendedor, bool estacionamiento, EMedioDePago medioDePago)
        {
            this.vendedor = vendedor;
            this.estacionamiento = estacionamiento;
            this.medioDePago = medioDePago;
            consumiciones = new Dictionary<Producto, int>();
            //fechaYhora = DateTime.Now; Lo agrego al momento de cerrar la cuenta y cobrar o ahora?
        }

        public void CalcularTotal()
        {
            foreach(KeyValuePair<Producto, int> producto in this.consumiciones)
            {
                total += producto.Key.Precio * producto.Value;
            }

            if(this.medioDePago == EMedioDePago.Crédito)
            {
                total *= 1.1f;
            }

            if(estacionamiento == true)
            {
                total += 500;
            }
        }
    }
}
