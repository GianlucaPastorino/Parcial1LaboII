using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bebida : Producto
    {
        public enum ETipo
        {
            Cerveza, Gaseosa, Agua, Trago, Otro
        }

        ETipo tipo;

        public ETipo Tipo
        {
            get => tipo;
        }

        public Bebida(ETipo tipo, string nombre, ETamaño tamaño, float precio, int stock) : base (nombre, tamaño, precio, stock)
        {
            this.tipo = tipo;
        }

        public Bebida(ETipo tipo, string nombre, ETamaño tamaño, float precio) : this(tipo, nombre, tamaño, precio, 0)
        {
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());

            switch(tipo)
            {
                case ETipo.Cerveza:
                    switch(Tamaño)
                    {
                        case ETamaño.Chico:
                            sb.Append(" | 1/2 Pinta");
                            break;
                        case ETamaño.Mediano:
                            sb.Append(" | Pinta");
                            break;
                        case ETamaño.Grande:
                            sb.Append(" | Botella 1 litro");
                            break;
                    }
                    break;
                case ETipo.Gaseosa:
                case ETipo.Agua:
                    switch(Tamaño)
                    {
                        case ETamaño.Chico:
                            sb.Append(" | 350 ml");
                            break;
                        case ETamaño.Mediano:
                            sb.Append(" | 500 ml");
                            break;
                        case ETamaño.Grande:
                            sb.Append(" | 1,25 lts");
                            break;
                    }
                    break;
            }

            return sb.ToString();
        }
    }
}