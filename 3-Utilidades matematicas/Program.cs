int opcion;
do
{
    menu();
    switch(opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el radio del circulo");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine($"El area del criculo es de: {areaCirculo(radio)}");
            limpiar();
        break;

        case 2:
            Console.WriteLine("Ingrese la base del triangulo");
            double baseTri = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo");
            double alturaTri = double.Parse(Console.ReadLine());
            Console.WriteLine($"El area del triangulo es de: {areaTriangulo(baseTri,alturaTri)}");
            limpiar();
        break;

        case 3:
            Console.WriteLine("Ingrese el numero a sacar factorial");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"El factorial del numero es de: {factorialNum(numero)}");
            limpiar();
        break;

        case 4:
            Console.WriteLine("Ingrese el numero a determinar si es par o impar");
            int num = int.Parse(Console.ReadLine());
            if(parOimpar(num) == true)
            {
                Console.WriteLine("Es par");
            }
            else if(parOimpar(num) == false)
            {
                Console.WriteLine("Es impar");
            }
            limpiar();
        break;

        case 5:
            Console.WriteLine("Saliendo...");
        break;

        default:
            Console.WriteLine("Opción no válida");
            limpiar();
        break;
    }
} while (opcion != 5);




void menu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Calcular area de un circulo");
    Console.WriteLine("2. Calcular el area de un triangulo");
    Console.WriteLine("3. Factorial de un numero");
    Console.WriteLine("4. Determinar si es par o impar");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Elija una opción");
    opcion = int.Parse(Console.ReadLine());
}

double areaCirculo(double radio)
{
    return 3.1416 * (radio * radio);
}

double areaTriangulo(double baseTri, double alturaTri)
{
    return 0.5 * (baseTri * alturaTri);
}

int factorialNum(int numero)
{
    int factorial = 1;
    for(int i = numero; i >= 1; i--)
    {
        factorial = factorial * i;
    }
    return factorial;
}

bool parOimpar(int numero)
{
    if(numero % 2 == 0)
    {
        return true; 
    }
    else
    {
        return false;
    }
}

void limpiar()
{
    Console.WriteLine("Presione cualquier tecla para continuar");
    Console.ReadKey();
    Console.Clear();
}