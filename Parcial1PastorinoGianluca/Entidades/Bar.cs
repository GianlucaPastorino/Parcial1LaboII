using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Bar
    {
        static List<Usuario> usuarios;
        static List<Producto> productos;
        static List<Pedido> ventas;
        static Sector[] ubicaciones;

        public static List<Usuario> Usuarios
        {
            get => usuarios;
        }

        public static Sector[] Ubicaciones
        {
            get => ubicaciones;
        }

        public static List<Producto> Productos
        {
            get => productos;
        }
        public static List<Pedido> Ventas
        {
            get => ventas;
            set => ventas = value;
        }

        static Bar()
        {
            usuarios = Datos.HardcodearUsuarios();
            productos = Datos.HardcodearInventario();
            ventas = Datos.HardcodearVentas();
            ubicaciones = Datos.InstanciarUbicaciones();
        }

        public static Usuario validarLogin(string strDni, string contraseña)
        {
            if (strDni is not null && contraseña is not null)
            {
                if (int.TryParse(strDni, out int dni))
                {
                    foreach (Usuario usuario in usuarios)
                    {
                        if (dni == usuario && usuario.CheckearContraseña(contraseña))
                        {
                            return usuario;
                        }
                    }
                }
            }
            return null;
        }

        public static float CalcularTotalVentas()
        {
            float total = 0;

            foreach(Pedido venta in Bar.ventas)
            {
                total += venta.Total;
            }

            return total;
        }
    }
}
