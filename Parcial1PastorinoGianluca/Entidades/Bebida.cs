using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Bebida : Producto
    {
        public enum ETipo
        {
            Cerveza, Gaseosa, Otro
        }

        ETipo tipo;

        public Bebida(ETipo tipo, string nombre, ETamaño tamaño, float precio, int stock) : base (nombre, tamaño, precio, stock)
        {
            this.tipo = tipo;
        }
    }
}
