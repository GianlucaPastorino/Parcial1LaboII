# Parcial 1 Laboratorio II - Gianluca Pastorino

**Clases Entidades:**

- Clase estática Bar: Engloba todo lo que posee mi bar (usuarios que pueden ingresar al sistema, una lista de productos/inventario, una lista de ventas realizadas y las mesas/barras).
- Clase Producto: clase abstracta la cual va a ser clase base de las clases Comida y Bebida.
- Clase Pedido: posee toda la información de los pedidos que realicen nuestros clientes (productos adquiridos, medio de pago, etc.).
- Clase Sector: hace referencia a cada mesa y lugar en la barra, las cuales van a poseer pedidos.
- Clase Usuario: refiere a los distintos usuarios que accederán a nuestro programa (empleados/administradores).
- Clase Datos: clase encargada de instanciar toda la información necesaria para el programa.

**Funcionalidad Formularios:**

- Menú Principal:
1) El usuario podrá ocupar una mesa/barra haciendo click en la mesa/barra libre que desea ocupar, y posteriormente clickeando en el botón dinámico inferior ("Ocupar Mesa x").
2) El usuario podrá liberar la mesa/barra ocupada presionando el mismo botón.
3) Una mesa/barra ocupada que posea un pedido activo no podrá ser liberada si no se ha cobrado el pedido. Primero deberá cobrar el pedido, y luego liberarla.
4) Una mesa/barra cobrada no podrá recibir más consumiciones.
5) A una mesa/barra ocupada se le podrá agregar consumisiones haciendo doble click en el item del menú que desea agregar (añadirá una unidad), o bien podrá añadir las unidades que desee estableciendolas en el combobox inferior del menú y posteriormente presionando "Agregar".
6) En caso de agregar un item por error, el usuario podrá eliminar el producto del pedido haciendo doble click en el item del datagridview "Pedido" que desea remover.
7) En caso de agregar una cantidad equivocada, el usuario podrá modificarla haciendo click en la celda correspondiente de la columna "cantidad".

- Menú Inventario:
1) En el inventario, las unidades con poco stock tendrán distintas tonalidades de rojo, según la cantidad disponible del mismo.
2) Se podrá buscar un producto por su nombre desde el cuadro de texto superior.
3) El administrador podrá agregar productos, agregar stock o bien, en caso de un error, podrá modificar el stock directamente desde la celda "cantidad".

- Menú Ventas:
1) Se podrán ver las ventas y buscar por nombre de vendedor.

- Menú Empleados:
1) El administrador tendrá acceso a este menú, y podrá ver la información de los empleados registrados en el sistema.



