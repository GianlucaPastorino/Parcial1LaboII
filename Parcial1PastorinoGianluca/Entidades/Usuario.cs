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

        public bool EsAdmin
        {
            get => esAdmin;
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

        public static bool operator ==(int dni, Usuario u)
        {
            if (u is not null)
            {
                return dni == u.dni;
            }

            return false;
        }

        public static bool operator !=(int dni, Usuario u)
        {
            return !(dni == u);
        }
    }
}