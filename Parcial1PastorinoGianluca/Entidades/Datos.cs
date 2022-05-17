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
            usuarios.Add(new Usuario("Gianluca", "ElCreador", 40936456, true));
            usuarios.Add(new Usuario("Lucas", "PepeRufoso", 38980847, true));
            usuarios.Add(new Usuario("Mauricio", "MiamiPenthouse", 35128776, true));
            usuarios.Add(new Usuario("Lautaro", "VarelaGang", 41520934, true));
            //EMPLEADOS
            usuarios.Add(new Usuario("Diego", "BarrileteCosmico10", 14276579, false));
            usuarios.Add(new Usuario("Roberto", "Musso.CDN", 16582013, false));
            usuarios.Add(new Usuario("Lionel", "AnkaraMessi", 33016244, false));

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
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Porción de Fritas chica", Producto.ETamaño.Chico, 400, 500));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Porción de Fritas mediana", Producto.ETamaño.Mediano, 450, 500));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Porción de Fritas grande", Producto.ETamaño.Grande, 500, 500));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Papas con cheddar", Producto.ETamaño.Unico, 600, 300));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Papas con cheddar, bacon y verdeo", Producto.ETamaño.Unico, 700, 300));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Aros de cebolla", Producto.ETamaño.Unico, 550, 500));
            inventario.Add(new Comida(Comida.ETipo.Entrada, "Salchipapa", Producto.ETamaño.Unico, 600, 300));

            // HAMBURGUESAS
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Sobrecargadora", Producto.ETamaño.Chico, 800, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Sobrecargadora doble", Producto.ETamaño.Mediano, 900, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Sobrecargadora triple", Producto.ETamaño.Grande, 1000, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Polimorfica", Producto.ETamaño.Chico, 750, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Polimorfica doble", Producto.ETamaño.Mediano, 800, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Polimorfica triple", Producto.ETamaño.Grande, 850, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Heredera", Producto.ETamaño.Chico, 900, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Heredera doble", Producto.ETamaño.Mediano, 1000, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Heredera triple", Producto.ETamaño.Grande, 1100, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La especial UTN", Producto.ETamaño.Chico, 1000, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La especial UTN doble", Producto.ETamaño.Mediano, 1100, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La especial UTN triple", Producto.ETamaño.Grande, 1200, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Encapsulada", Producto.ETamaño.Chico, 850, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Encapsulada doble", Producto.ETamaño.Mediano, 900, 200));
            inventario.Add(new Comida(Comida.ETipo.Hamburguesa, "La Encapsulada triple", Producto.ETamaño.Grande, 950, 200));

            // POSTRE
            inventario.Add(new Comida(Comida.ETipo.Postre, "Helado", Producto.ETamaño.Unico, 500, 400));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Tiramisú", Producto.ETamaño.Unico, 500, 170));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Flan con DDL", Producto.ETamaño.Unico, 450, 300));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Panqueque con DDL", Producto.ETamaño.Unico, 550, 150));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Ensalada de frutas", Producto.ETamaño.Unico, 400, 250));
            inventario.Add(new Comida(Comida.ETipo.Postre, "Porción de torta", Producto.ETamaño.Unico, 650, 100));

            // BEBIDAS
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Porter", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Porter", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Stout", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Stout", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Honey", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Honey", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "IPA", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "IPA", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Pilsen", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Pilsen", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Scottish", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Scottish", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Weizen", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Weizen", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "APA", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "APA", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Golden", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Golden", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Lager", Producto.ETamaño.Chico, 390, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Cerveza, "Lager", Producto.ETamaño.Mediano, 470, 300));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Coca-Cola", Producto.ETamaño.Unico, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Coca-Cola sin azúcar", Producto.ETamaño.Unico, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Sprite", Producto.ETamaño.Unico, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Sprite sin azúcar", Producto.ETamaño.Unico, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Fanta", Producto.ETamaño.Unico, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Gaseosa, "Fanta sin azúcar", Producto.ETamaño.Unico, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Agua sin gas", Producto.ETamaño.Unico, 220, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Agua con gas", Producto.ETamaño.Unico, 220, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Agua saborizada manzana", Producto.ETamaño.Unico, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Agua saborizada pomelo", Producto.ETamaño.Unico, 250, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Fernet con Coca", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Gin Tonic", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Cuba Libre", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Campari", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Carpano y Pomelo", Producto.ETamaño.Unico, 600, 200));
            inventario.Add(new Bebida(Bebida.ETipo.Otro, "Campari Tonic", Producto.ETamaño.Unico, 650, 200));

            return inventario;
        }

        // Hacer
        /*public static List<Pedido> HardcodearVentas(List<Pedido> ventas)
        {
            ventas.Add()
            return ventas;
        }*/
    }
}
