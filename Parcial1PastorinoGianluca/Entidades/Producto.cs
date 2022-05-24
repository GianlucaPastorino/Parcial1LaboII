using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        public enum ETamaño
        {
            Chico, Mediano, Grande, Unico
        }

        static int ultimoId;
        int idProducto;
        float precio;
        int stock;
        string nombre;
        ETamaño tamaño;

        public int IdProducto
        {
            get => idProducto;
        }

        public float Precio
        {
            get => precio;
        }

        public string Nombre
        {
            get => nombre;
        }

        public int Stock
        {
            get => stock;
            set
            {
                if(value >= 0)
                {
                    stock = value;
                }
            }
        }

        public ETamaño Tamaño
        {
            get => tamaño;
        }

        static Producto()
        {
            ultimoId = 1;
        }

        public Producto(string nombre, ETamaño tamaño, float precio, int stock)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
            this.stock = stock;
            idProducto = ultimoId;
            ultimoId++;
        }

        public virtual string Mostrar()
        {
            return nombre;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return p1.idProducto == p2.idProducto;
            }

            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, int id)
        {
            if (p is not null)
            {
                return p.idProducto == id;
            }

            return false;
        }
        public static bool operator !=(Producto p, int id)
        {
            return !(p == id);
        }

        public static Producto operator +(Producto p, int cantidad)
        {
            p.stock += cantidad;
            return p;
        }

        public static Producto operator -(Producto p, int cantidad)
        {
            p += -cantidad;
            return p;
        }

        public static bool ConsultarDisponibilidadDeStock(List<Producto> productos, Producto producto, int cantidad)
        {
            Producto auxProducto = BuscarProductoPorId(productos, producto.idProducto);

            if(auxProducto is not null)
            {
                if(cantidad <= auxProducto.stock)
                {
                    return true;
                }
            }

            return false;
        }

        public static Producto BuscarProductoPorId(List<Producto> productos, int id)
        {
            if (productos is not null)
            {
                foreach (Producto item in productos)
                {
                    if (item == id)
                    {
                        return item;
                    }
                }
            }

            return null;
        }

        public static Producto BuscarProductoPorId(List<Producto> productos, string strId)
        {
            if (int.TryParse(strId, out int id))
            {
                return BuscarProductoPorId(productos, id);
            }

            return null;
        }
    }
}