using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comida : Producto
    {
        public enum ETipo
        {
            Entrada, Hamburguesa, Postre, Otro
        }

        ETipo tipo;

        public ETipo Tipo
        {
            get => tipo;
        }

        public Comida(ETipo tipo, string nombre, ETamaño tamaño, float precio, int stock) : base(nombre, tamaño, precio, stock)
        {
            this.tipo = tipo;
        }

        public Comida(ETipo tipo, string nombre, ETamaño tamaño, float precio) : this(tipo, nombre, tamaño, precio, 0)
        {
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());

            switch (tipo)
            {
                case ETipo.Entrada:
                case ETipo.Postre:
                    switch (Tamaño)
                    {
                        case ETamaño.Chico:
                            sb.Append(" chico/a");
                            break;
                        case ETamaño.Mediano:
                            sb.Append(" mediano/a");
                            break;
                        case ETamaño.Grande:
                            sb.Append(" grande");
                            break;
                    }
                    break;
                case ETipo.Hamburguesa:
                    switch (Tamaño)
                    {
                        case ETamaño.Mediano:
                            sb.Append(" doble");
                            break;
                        case ETamaño.Grande:
                            sb.Append(" triple");
                            break;
                    }
                    break;
            }

            return sb.ToString();
        }
    }
}