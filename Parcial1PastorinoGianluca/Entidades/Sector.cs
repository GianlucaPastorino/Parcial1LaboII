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
        Pedido pedido;

        public Sector(ETipo tipo)
        {
            this.tipo = tipo;
            estaLibre = true;
        }
    }
}
