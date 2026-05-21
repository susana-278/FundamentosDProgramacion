using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class supermercado
{
    // DATOS 

    // Usuarios
    static string[] usuarioNombre = new string[20];
    static string[] usuarioApellido = new string[20];
    static string[] usuarioCC = new string[20];
    static int totalUsuarios = 0;

    // Artículos
    static string[] articuloNombre = new string[20];
    static string[] articuloId = new string[20];
    static double[] articuloPrecio = new double[20];
    static int totalArticulos = 0;

    // MENÚ PRINCIPAl

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            MostrarMenuPrincipal();
            opcion = CapturarOpcion();
            EjecutarOpcionPrincipal(opcion);
        } while (opcion != 4);
    }

    static void MostrarMenuPrincipal()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|        SUPERMERCADO - MENÚ           |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|  1. Gestión de usuarios              |");
        Console.WriteLine("|  2. Gestión de artículos             |");
        Console.WriteLine("|  3. Gestión de ventas                |");
        Console.WriteLine("|  4. Salir del programa               |");
        Console.WriteLine("----------------------------------------");

    }

    static void EjecutarOpcionPrincipal(int opcion)
    {
        switch (opcion)
        {
            case 1:
                MenuUsuarios();
                break;

            case 2:
                MenuArticulos();
                break;

            case 3:
                MenuVentas();
                break;
            case 4:
                MensajeSalida();
                break;
            default:
                MensajeOpcionInvalida();
                break;
        }
    }

    // GESTIÓN DE USUARIOS
    static void MenuUsuarios()
    {
        int opcion;
        do
        {
            MostrarMenuUsuarios();
            opcion = CapturarOpcion();
            EjecutarOpcionUsuarios(opcion);
        } while (opcion != 4);
    }

    static void MostrarMenuUsuarios()
    {

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|        GESTIÓN DE USUARIOS           |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|  1. Ver lista de usuarios            |");
        Console.WriteLine("|  2. Nuevo usuario                    |");
        Console.WriteLine("|  3. Editar usuario (buscar por C.C.) |");
        Console.WriteLine("|  4. Volver al menú principal         |");
        Console.WriteLine("----------------------------------------");
    }

    static void EjecutarOpcionUsuarios(int opcion)
    {
        switch (opcion)
        {
            case 1:
                VerListaUsuarios();
                break;

            case 2:
                NuevoUsuario();
                break;

            case 3:
                EditarUsuario();
                break;

            case 4:
                break;

            default:
                MensajeOpcionInvalida();
                break;
        }
    }

    static void VerListaUsuarios()
    {

        Console.WriteLine("--LISTA DE USUARIOS--");
        if (totalUsuarios == 0)
        {
            Console.WriteLine("No hay usuarios registrados.");
        }
        else
        {
            Console.WriteLine($"{"#",-4} {"C.C.",-15} {"Nombre",-15} {"Apellido",-15}");
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < totalUsuarios; i++)
            {
                Console.WriteLine($"{i + 1,-4} {usuarioCC[i],-15} {usuarioNombre[i],-15} {usuarioApellido[i],-15}");
            }
        }
        Pausa();

    }

    static void NuevoUsuario()
    {
        Console.WriteLine("--NUEVO USUARIO--");
        if (totalUsuarios >= 20)
        {
            Console.WriteLine("Se alcanzó el límite de 20 usuarios.");
            Pausa();
            return;
        }

        Console.Write("C.C.: ");
        usuarioCC[totalUsuarios] = Console.ReadLine();

        Console.Write("Nombre: ");
        usuarioNombre[totalUsuarios] = Console.ReadLine();

        Console.Write("Apellido: ");
        usuarioApellido[totalUsuarios] = Console.ReadLine();

        totalUsuarios++;
        Console.WriteLine("Usuario registrado correctamente.");
        Pausa();
    }

    static void EditarUsuario()
    {

        Console.WriteLine("--EDITAR USUARIO--");
        Console.Write("Ingrese la C.C. del usuario a editar: ");
        string cc = Console.ReadLine();

        int indice = BuscarUsuarioPorCC(cc);
        if (indice == -1)
        {
            Console.WriteLine("Usuario no encontrado.");
            Pausa();
            return;
        }

        Console.WriteLine($"Usuario encontrado: {usuarioNombre[indice]} {usuarioApellido[indice]}");
        Console.Write("Nuevo nombre (Enter para mantener): ");
        string nuevoNombre = Console.ReadLine();
        if (nuevoNombre != "") usuarioNombre[indice] = nuevoNombre;

        Console.Write("Nuevo apellido (Enter para mantener): ");
        string nuevoApellido = Console.ReadLine();
        if (nuevoApellido != "") usuarioApellido[indice] = nuevoApellido;

        Console.WriteLine("Usuario actualizado correctamente.");
        Pausa();
    }

    static int BuscarUsuarioPorCC(string cc)
    {
        for (int i = 0; i < totalUsuarios; i++)
            if (usuarioCC[i] == cc) return i;
        return -1;
    }

    //GESTIÓN DE ARTÍCULOS

    static void MenuArticulos()
    {
        int opcion;
        do
        {
            MostrarMenuArticulos();
            opcion = CapturarOpcion();
            EjecutarOpcionArticulos(opcion);
        } while (opcion != 4);
    }

    static void MostrarMenuArticulos()
    {

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|        GESTIÓN DE ARTÍCULOS          |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|  1. Ver lista de artículos           |");
        Console.WriteLine("|  2. Nuevo artículo                   |");
        Console.WriteLine("|  3. Editar artículo (buscar por ID)  |");
        Console.WriteLine("|  4. Volver al menú principal         |");
        Console.WriteLine("----------------------------------------");
    }

    static void EjecutarOpcionArticulos(int opcion)
    {
        switch (opcion)
        {
            case 1:
                VerListaArticulos();
                break;

            case 2:
                NuevoArticulo();
                break;

            case 3:
                EditarArticulo();
                break;

            case 4:
                break;

            default:
                MensajeOpcionInvalida();
                break;
        }
    }

    static void VerListaArticulos()
    {

        Console.WriteLine("--LISTA DE ARTÍCULOS--");
        if (totalArticulos == 0)
        {
            Console.WriteLine("No hay artículos registrados.");
        }
        else
        {
            Console.WriteLine($"{"#",-4} {"ID",-10} {"Nombre",-20} {"Precio",-10}");
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < totalArticulos; i++)
            {
                Console.WriteLine($"{i + 1,-4} {articuloId[i],-10} {articuloNombre[i],-20} ${articuloPrecio[i],-10:0.00}");
            }
        }
        Pausa();
    }

    static void NuevoArticulo()
    {

        Console.WriteLine("--NUEVO ARTÍCULO--");
        if (totalArticulos >= 20)
        {
            Console.WriteLine("Se alcanzó el límite de 20 artículos.");
            Pausa();
            return;
        }

        Console.Write("ID del artículo: ");
        articuloId[totalArticulos] = Console.ReadLine();

        Console.Write("Nombre: ");
        articuloNombre[totalArticulos] = Console.ReadLine();

        Console.Write("Precio: $");
        articuloPrecio[totalArticulos] = double.Parse(Console.ReadLine());

        totalArticulos++;
        Console.WriteLine("Artículo registrado correctamente.");
        Pausa();
    }

    static void EditarArticulo()
    {

        Console.WriteLine("--EDITAR ARTÍCULO--");
        Console.Write("Ingrese el ID del artículo a editar: ");
        string id = Console.ReadLine();

        int indice = BuscarArticuloPorId(id);
        if (indice == -1)
        {
            Console.WriteLine("Artículo no encontrado.");
            Pausa();
            return;
        }

        Console.WriteLine($"Artículo encontrado: {articuloNombre[indice]} - ${articuloPrecio[indice]:0.00}");

        Console.Write("Nuevo nombre (Enter para mantener): ");
        string nuevoNombre = Console.ReadLine();
        if (nuevoNombre != "") articuloNombre[indice] = nuevoNombre;

        Console.Write("Nuevo precio (0 para mantener): $");
        double nuevoPrecio = double.Parse(Console.ReadLine());
        if (nuevoPrecio > 0) articuloPrecio[indice] = nuevoPrecio;

        Console.WriteLine("Artículo actualizado correctamente.");
        Pausa();
    }

    static int BuscarArticuloPorId(string id)
    {
        for (int i = 0; i < totalArticulos; i++)
            if (articuloId[i] == id) return i;
        return -1;
    }

    // ─── GESTIÓN DE VENTAS ────────────────────────────────────────────────────

    static void MenuVentas()
    {

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|       GESTIÓN DE VENTAS              |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|  1. Registrar venta                  |");
        Console.WriteLine("|  2. Volver al menú principal         |");
        Console.WriteLine("----------------------------------------");

        int opcion = CapturarOpcion();
        switch (opcion)
        {
            case 1: RegistrarVenta(); break;
            case 2: break;
            default: MensajeOpcionInvalida(); break;
        }
    }

    static void RegistrarVenta()
    {

        Console.WriteLine("--REGISTRAR VENTA--");

        //Seleccionar usuario
        int indiceUsuario = SeleccionarUsuario();
        if (indiceUsuario == -1) return;

        //Seleccionar artículos y cantidades
        int[] articulosSeleccionados = new int[20];
        int[] cantidades = new int[20];
        int totalItems = 0;
        bool agregarMas = true;

        while (agregarMas && totalItems < 20)
        {
            int indiceArticulo = SeleccionarArticulo();
            if (indiceArticulo == -1) break;

            Console.Write($"Cantidad de '{articuloNombre[indiceArticulo]}': ");
            int cantidad = int.Parse(Console.ReadLine());

            articulosSeleccionados[totalItems] = indiceArticulo;
            cantidades[totalItems] = cantidad;
            totalItems++;

            if (totalItems < 20)
            {
                Console.Write("¿Agregar otro artículo? (s/n): ");
                agregarMas = Console.ReadLine().ToLower() == "s";
            }
        }

        //Generar y mostrar factura
        MostrarFactura(indiceUsuario, articulosSeleccionados, cantidades, totalItems);
    }

    static int SeleccionarUsuario()
    {
        Console.WriteLine("\n── Seleccionar usuario ──");
        if (totalUsuarios == 0)
        {
            Console.WriteLine("No hay usuarios registrados. Registre uno primero.");
            Pausa();
            return -1;
        }

        VerListaUsuariosCompacta();
        Console.Write("Ingrese la C.C. del usuario: ");
        string cc = Console.ReadLine();
        int indice = BuscarUsuarioPorCC(cc);

        if (indice == -1)
        {
            Console.WriteLine("Usuario no encontrado.");
            Pausa();
        }
        return indice;
    }

    static void VerListaUsuariosCompacta()
    {
        for (int i = 0; i < totalUsuarios; i++)
            Console.WriteLine($"  [{usuarioCC[i]}] {usuarioNombre[i]} {usuarioApellido[i]}");
    }

    static int SeleccionarArticulo()
    {
        Console.WriteLine(" Seleccionar artículo ──");
        if (totalArticulos == 0)
        {
            Console.WriteLine("No hay artículos registrados.");
            Pausa();
            return -1;
        }

        for (int i = 0; i < totalArticulos; i++)
            Console.WriteLine($"  [{articuloId[i]}] {articuloNombre[i]} - ${articuloPrecio[i]:0.00}");

        Console.Write("Ingrese el ID del artículo: ");
        string id = Console.ReadLine();
        int indice = BuscarArticuloPorId(id);

        if (indice == -1)
            Console.WriteLine("Artículo no encontrado.");

        return indice;
    }

    static void MostrarFactura(int indiceUsuario, int[] articulos, int[] cantidades, int totalItems)
    {

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|           FACTURA DE VENTA            |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Cliente : {usuarioNombre[indiceUsuario]} {usuarioApellido[indiceUsuario]}");
        Console.WriteLine($"C.C.    : {usuarioCC[indiceUsuario]}");
        Console.WriteLine($"Fecha   : {DateTime.Now:dd/MM/yyyy HH:mm}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"{"Artículo",-20} {"Cant",-6} {"Precio",-10} {"Subtotal"}");
        Console.WriteLine("----------------------------------------");

        double total = CalcularTotal(articulos, cantidades, totalItems);

        for (int i = 0; i < totalItems; i++)
        {
            int idx = articulos[i];
            double subtotal = articuloPrecio[idx] * cantidades[i];
            Console.WriteLine($"{articuloNombre[idx],-20} {cantidades[i],-6} ${articuloPrecio[idx],-10:0.00} ${subtotal:0.00}");
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"{"TOTAL:",-38} ${total:0.00}");
        Console.WriteLine("----------------------------------------");
        Pausa();
    }

    static double CalcularTotal(int[] articulos, int[] cantidades, int totalItems)
    {
        double total = 0;
        for (int i = 0; i < totalItems; i++)
            total += articuloPrecio[articulos[i]] * cantidades[i];
        return total;
    }

    // UTILIDADES

    static int CapturarOpcion()
    {
        Console.Write("Seleccione una opción: ");
        int resultado;
        while (!int.TryParse(Console.ReadLine(), out resultado))
        {
            Console.Write("Ingrese un número válido: ");
        }
        return resultado;
    }

    static void Pausa()
    {
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void MensajeSalida()
    {

        Console.WriteLine("Hasta pronto.");
    }

    static void MensajeOpcionInvalida()
    {
        Console.WriteLine("Opción no válida. Intente de nuevo.");
        Pausa();
    }
}