using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Comida : Producto
    {
        public enum ETipo
        {
            Entrada, Hamburguesa, Postre, Otro
        }

        ETipo tipo;

        public Comida(ETipo tipo, string nombre, ETamaño tamaño, float precio, int stock) : base(nombre, tamaño, precio, stock)
        {
            this.tipo = tipo;
        }
    }
}
