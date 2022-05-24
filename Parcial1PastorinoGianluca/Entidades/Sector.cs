using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sector
    {
        public enum ETipo
        {
            Mesa, Barra
        }

        ETipo tipo;
        bool estaLibre;
        Pedido pedidoActual;

        public bool EstaLibre
        {
            get => estaLibre;
            set => estaLibre = value;
        }

        public ETipo Tipo
        {
            get => tipo;
        }

        public Pedido PedidoActual
        {
            get => pedidoActual;
        }


        public Sector(ETipo tipo)
        {
            this.tipo = tipo;
            estaLibre = true;
        }

        public void CambiarEstado(Usuario vendedor)
        {
            if(estaLibre)
            {
                pedidoActual = new Pedido(vendedor);
            }
            else
            {
                pedidoActual = null;
            }

            estaLibre = !estaLibre;

        }
    }
}
