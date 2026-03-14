int opcion;
string nomProduct = "";
int cantProduct = 0;
int cantVentas = 0;
double precioProduct = 0;
double total = 0;
double totalVentas = 0;
double ventaMayor = 0;
do
{
    menu();
    switch(opcion)
    {
        case 1:
            registroVenta();
            Console.WriteLine("Presione cualquier tecla para seguir");
            Console.ReadKey();
            Console.Clear();
        break;

        case 2:
            if(nomProduct == "" && cantProduct == 0 && precioProduct == 0)
            {
                Console.WriteLine("No ha ingresado datos");
                Console.WriteLine("Presione cualquier tecla para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Producto vendido: {nomProduct}");
                Console.WriteLine($"Cantidad vendida: {cantProduct}");
                Console.WriteLine($"Precio unitario del producto: {precioProduct}");
                Console.WriteLine($"El total de la venta es de: {total}");
                Console.WriteLine("Presione cualquier tecla para seguir");
                Console.ReadKey();
                Console.Clear();
            }
        break;

        case 3:
            if(nomProduct == "" && cantProduct == 0 && precioProduct == 0)
            {
                Console.WriteLine("No ha ingresado datos");
                Console.WriteLine("Presione cualquier tecla para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"El total de las ventas es de: {totalVentas}");
                Console.WriteLine($"El promedio de las ventas realizadas es de: {totalVentas/cantVentas}");
                Console.WriteLine("Presione cualquier tecla para seguir");
                Console.ReadKey();
                Console.Clear();
            }
        break;

        case 4:
            if(ventaMayor == 0)
            {
                Console.WriteLine("No existe venta mayor aún");
                Console.WriteLine("Presione cualquier tecla para seguir");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"La venta mayor ingresada es de: {ventaMayor}");
                Console.WriteLine("Presione cualquier tecla para seguir");
                Console.ReadKey();
                Console.Clear();
            }
        break;

        case 5:
            Console.WriteLine("Saliendo...");
        break;

        default:
            Console.WriteLine("Opción no válida");
            Console.WriteLine("Presione cualquier tecla para seguir");
            Console.ReadKey();
            Console.Clear();
        break;
    }
} while (opcion != 5);






void menu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Registrar venta");
    Console.WriteLine("2. Mostrar total vendido");
    Console.WriteLine("3. Mostrar promedio de ventas");
    Console.WriteLine("4. Mostrar venta mayor registrada");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elija una opción");
    opcion = int.Parse(Console.ReadLine());
}

void registroVenta()
{
    Console.WriteLine("Ingrese el nombre de producto");
    nomProduct = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad vendida");
    cantProduct = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el precio por unidad");
    precioProduct = double.Parse(Console.ReadLine());
    total = totalVenta(cantProduct, precioProduct);
    if(cantVentas == 0)
    {
        ventaMayor = total;
    }
    else if(ventaMayor < total)
    {
        ventaMayor = total;
    }
    totalVentas += total;
    cantVentas++;
}

double totalVenta(double cantProduct, double precioProduct)
{
    return cantProduct * precioProduct;
}