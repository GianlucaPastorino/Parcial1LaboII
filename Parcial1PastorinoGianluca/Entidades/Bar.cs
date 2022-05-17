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

        static Bar()
        {
            usuarios = Datos.HardcodearUsuarios();
            productos = Datos.HardcodearInventario();
            ventas = new List<Pedido>();
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
                        if (dni == usuario.Dni && usuario.CheckearContraseña(contraseña))
                        {
                            return usuario;
                        }
                    }
                }
            }
            return null;
        }
    }
}
