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
        float precio;
        int stock;
        string nombre;
        ETamaño tamaño;

        public float Precio { get => precio; }

        public Producto(string nombre, ETamaño tamaño, float precio, int stock)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
            this.stock = stock; 
        }
    }
}
