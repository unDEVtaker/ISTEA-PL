// 7. Crear una estructura que contenga: Edad, peso, altura y nombre de persona. 
//Indicar los tipos de datos apropiados. Luego desde un menú imprimir cada dato según lo elija el usuario.

Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());
Console.Write("Ingrese su peso: ");
double peso = double.Parse(Console.ReadLine());
Console.Write("Ingrese su altura: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Que desea ver primero?");
Console.WriteLine("1. Nombre.");
Console.WriteLine("2. Edad.");
Console.WriteLine("3. Peso.");
Console.WriteLine("4. Altura."); 
Console.WriteLine("0. Salir.");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        imprimirNombre(nombre);
        break;
    case 2:
        imprimirEdad(edad);
        break;
    case 3:
        imprimirPeso(peso);
        break;
    case 4:
        imprimirAltura(altura);
        break;
    case 0:
        Console.WriteLine("Programa terminado.");
        return;
    default:
        Console.WriteLine("Opcion no valida.");
        break;
}


static void imprimirNombre(string nombre){
    Console.WriteLine($"Su nombre es: {nombre}");
}
static void imprimirEdad(int edad){
    Console.WriteLine($"Su edad es: {edad} años");
}
static void imprimirPeso(double peso){
    Console.WriteLine($"Su peso es: {peso}kg");
}
static void imprimirAltura(double altura){
    Console.WriteLine($"Su altura es: {altura}cm");
}