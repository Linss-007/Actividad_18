int opcion;
string nomProduct = "";
int cantProduct = 0;
double precioProduct = 0;
double total = 0;
do
{
    menu();
    switch(opcion)
    {
        case 1:
            registroVenta();
        break;

        case 2:
            if(nomProduct == "" && cantProduct == 0 && precioProduct == 0)
            {
                Console.WriteLine("No ha ingresado datos");
            }
            else
            {
                Console.WriteLine($"El total de la venta es de: {total}");
            }
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
}

double totalVenta(double cantProduct, double precioProduct)
{
    return cantProduct * precioProduct;
}