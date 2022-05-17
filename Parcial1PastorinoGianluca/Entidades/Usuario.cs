using System;

namespace Entidades
{
    public class Usuario
    {
        string nombre;
        string contraseña;
        int dni;
        bool esAdmin;

        public Usuario(string nombre, string contraseña, int dni, bool esAdmin)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.dni = dni;
            this.esAdmin = esAdmin;
        }

        public string Nombre
        {
            get => nombre;
        }

        public int Dni
        {
            get => dni;
        }

        /// <summary>
        /// Chequea que la contraseña recibida sea igual a la contraseña del usuario
        /// </summary>
        /// <param name="contraseña">Contraseña a verificar</param>
        /// <returns>true si la contraseña es correcta, false si es incorrecta</returns>
        public bool CheckearContraseña(string contraseña)
        {
            return contraseña == this.contraseña;
        } 

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            if (u1 is not null && u2 is not null)
            {
                return u1.dni == u2.dni;
            }

            return false;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }
    }
}