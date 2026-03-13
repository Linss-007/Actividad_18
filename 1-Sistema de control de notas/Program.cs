int opcion;
string nombre = "";
double nota1;
double nota2;
double nota3;
double promedio = 0;
double promGeneral = 0;
int aprobados = 0;
int reprobados = 0;
int cantAlumno = 0;
do
{
    menu();
    switch(opcion)
    {
        case 1:
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la nota 1");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3");
            nota3 = double.Parse(Console.ReadLine());
            promedio = promedioAlumno(nota1, nota2, nota3);
            cantAlumno ++;
            promGeneral += promedio;
        break;

        case 2:
            if (nombre == "" && promedio == 0)
            {
                Console.WriteLine("Aun no se han ingresado datos");
            }
            else
            {
                resultado(nombre, promedio);
            }
        break;

        case 3:
            if(nombre == "" && promedio == 0)
            {
                Console.WriteLine("No se han ingresado datos");
            }
            else
            {
                Console.WriteLine($"La cantidad de aprobados es de: {aprobados}");
                Console.WriteLine($"La cantidad de reprobados es de: {reprobados}");
                Console.WriteLine($"Promedio general de los alumnos {promGeneral / cantAlumno}");
            }
        break;

        case 4:
            Console.WriteLine("Saliendo...");
        break;

        default:
            Console.WriteLine("Opcion no valida");
        break;
    }

}while(opcion != 4);




void menu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Registrar estudiante");
    Console.WriteLine("2. Mostrar promedio general");
    Console.WriteLine("3. Mostrar cantidad de aprobados y reprobados");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Elija una opción");
    opcion = int.Parse(Console.ReadLine());
}

double promedioAlumno(double nota1, double nota2, double nota3)
{
    return (nota1 + nota2 + nota3)/3;
}

void resultado(string nombre, double promedio)
{
    Console.WriteLine($"{nombre} sus resultados son: ");
    Console.WriteLine($"Promedio: {promedio}");
    if(promedio >= 61)
    {
        Console.WriteLine("Aprobado");
        aprobados++;
    }
    else
    {
        Console.WriteLine("Reprobado");
        reprobados++;
    }
}