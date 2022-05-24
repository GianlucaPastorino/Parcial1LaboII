using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Datos
    {
        public static List<Usuario> HardcodearUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            //ADMINS
            usuarios.Add(new Usuario("Gianluca Pastorino", "ElCreador", 40936456, true));
            usuarios.Add(new Usuario("Lucas Rodriguez", "PepeRufoso", 38980847, true));
            usuarios.Add(new Usuario("Mauricio Cerizza", "MiamiPenthouse", 35128776, true));
            usuarios.Add(new Usuario("Lautaro Galarza", "VarelaGang", 41520934, true));
            //EMPLEADOS
            usuarios.Add(new Usuario("Diego Armando Maradona", "BarrileteCosmico10", 14276579, false));
            usuarios.Add(new Usuario("Roberto Musso", "Musso.CDN", 16582013, false));
            usuarios.Add(new Usuario("Lionel Andrés Messi", "AnkaraMessi", 33016244, false));
            usuarios.Add(new Usuario("Matias Gonzalez", "ApruebenmePorFavor", 43285749, false));

            return usuarios;
        }

        public static Sector[] InstanciarUbicaciones()
        {
            Sector[] ubicaciones = new Sector[20];

            ubicaciones[0] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[1] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[2] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[3] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[4] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[5] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[6] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[7] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[8] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[9] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[10] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[11] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[12] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[13] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[14] = new Sector(Sector.ETipo.Mesa);
            ubicaciones[15] = new Sector(Sector.ETipo.Barra);
            ubicaciones[16] = new Sector(Sector.ETipo.Barra);
            ubicaciones[17] = new Sector(Sector.ETipo.Barra);
            ubicaciones[18] = new Sector(Sector.ETipo.Barra);
            ubicaciones[19] = new Sector(Sector.ETipo.Barra);

            return ubicaciones;
        }

        public static List<Producto> HardcodearInventario()
        {
            List<Producto> inventario = new List<Producto>();

            // ENTRADAS
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Porción de Fritas", Producto.ETamaño.Chico, 400, 500));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Porción de Fritas", Producto.ETamaño.Mediano, 450, 500));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Porción de Fritas", Producto.ETamaño.Grande, 500, 500));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Papas con cheddar", Producto.ETamaño.Unico, 600, 300));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Papas con cheddar, bacon y verdeo", Producto.ETamaño.Unico, 700, 300));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Aros de cebolla", Producto.ETamaño.Unico, 550, 500));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Salchipapa", Producto.ETamaño.Unico, 600, 50));

            // HAMBURGUESAS
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Sobrecargadora", Producto.ETamaño.Chico, 700, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Sobrecargadora", Producto.ETamaño.Mediano, 800, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Sobrecargadora", Producto.ETamaño.Grande, 900, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Polimorfica", Producto.ETamaño.Chico, 650, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Polimorfica", Producto.ETamaño.Mediano, 700, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Polimorfica", Producto.ETamaño.Grande, 750, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Heredera", Producto.ETamaño.Chico, 800, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Heredera", Producto.ETamaño.Mediano, 900, 35));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Heredera", Producto.ETamaño.Grande, 1000, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Especial UTN", Producto.ETamaño.Chico, 900, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Especial UTN", Producto.ETamaño.Mediano, 1000, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Especial UTN", Producto.ETamaño.Grande, 1100, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Encapsulada", Producto.ETamaño.Chico, 750, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Encapsulada", Producto.ETamaño.Mediano, 800, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Encapsulada", Producto.ETamaño.Grande, 850, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Vegana", Producto.ETamaño.Unico, 800, 200));

            // POSTRE
            inventario.Add(new Comida(Comida.ETipo.Postre, "Helado", Producto.ETamaño.Unico, 500, 400));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Tiramisú", Producto.ETamaño.Unico, 500, 170));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Flan con DDL", Producto.ETamaño.Unico, 450, 300));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Panqueque con DDL", Producto.ETamaño.Unico, 550, 20));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Ensalada de frutas", Producto.ETamaño.Unico, 400, 250));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Porción de torta", Producto.ETamaño.Unico, 650, 100));

            // BEBIDAS
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Porter", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Porter", Producto.ETamaño.Mediano, 470, 0));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Stout", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Stout", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Honey", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Honey", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "IPA", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "IPA", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Pilsen", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Pilsen", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Scottish", Producto.ETamaño.Chico, 390, 40));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Scottish", Producto.ETamaño.Mediano, 470, 25));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Weizen", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Weizen", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "APA", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "APA", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Golden", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Golden", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Lager", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Lager", Producto.ETamaño.Mediano, 470, 300));

            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Coca-Cola", Producto.ETamaño.Mediano, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Coca-Cola sin azúcar", Producto.ETamaño.Mediano, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Sprite", Producto.ETamaño.Mediano, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Sprite sin azúcar", Producto.ETamaño.Mediano, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Fanta", Producto.ETamaño.Mediano, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Fanta sin azúcar", Producto.ETamaño.Mediano, 250, 200));

            inventario.Add(new Bebida(Bebida.ETipo.Agua, "Agua sin gas", Producto.ETamaño.Mediano, 220, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Agua, "Agua con gas", Producto.ETamaño.Mediano, 220, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Agua, "Agua saborizada manzana", Producto.ETamaño.Mediano, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Agua, "Agua saborizada pomelo", Producto.ETamaño.Mediano, 250, 200));

            inventario.Add(new Bebida(Bebida.ETipo.Trago, "Fernet con Coca", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Trago, "Gin Tonic", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Trago, "Cuba Libre", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Trago, "Campari", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Trago, "Carpano y Pomelo", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Trago, "Campari Tonic", Producto.ETamaño.Unico, 650, 200));

            return inventario;
        }

   
        public static List<Pedido> HardcodearVentas()
        {
            List<Pedido> ventas = new List<Pedido>();
            Dictionary<Producto, int> productos1 = new Dictionary<Producto, int>();
            Dictionary<Producto, int> productos2 = new Dictionary<Producto, int>();
            Dictionary<Producto, int> productos3 = new Dictionary<Producto, int>();
            
            productos1.Add(Bar.Productos[7], 2);
            ventas.Add(new Pedido(Bar.Usuarios[1], productos1, new DateTime(2022, 05, 20, 12, 35, 48), true, Pedido.EMedioDePago.Crédito));
            
            
            productos2.Add(Bar.Productos[15], 1);
            productos2.Add(Bar.Productos[30], 1);
            ventas.Add(new Pedido(Bar.Usuarios[2], productos2, new DateTime(2022, 05, 21, 21, 15, 20), false, Pedido.EMedioDePago.Débito));

            productos3.Add(Bar.Productos[45], 3);
            ventas.Add(new Pedido(Bar.Usuarios[6], productos3, new DateTime(2022, 05, 23, 13, 20, 54), true, Pedido.EMedioDePago.QR));

            return ventas;
        }
    }
}
