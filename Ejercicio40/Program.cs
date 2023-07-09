//Menú interactivo
//1. Elaborar un menú en el cual el usuario pueda elegir lo siguiente:
//a. 0: Salir del programa
//b. 1: Solicitar el nombre del usuario y responde “Hola xxxxx”.
//c. 2: Solicitar la edad y mostrar por pantalla “Su edad es xxxx.

string opcion;
bool salir = false;


while (!salir){
    Console.WriteLine("Menu interactivo");
    Console.WriteLine("1. Saludar.");
    Console.WriteLine("2 Mostar edad.");
    Console.WriteLine("0. Salir.");
    opcion = Console.ReadLine();
    switch (opcion){
        case "1":
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}.");
            break;
        case "2":
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tu edad es {edad}.");
            break;
        case "0":
            salir = true;
            break;
        default:
            Console.WriteLine("Opcion invalida. Intente nuevamente.");
            break;
    }
}
Console.WriteLine("Programa terminado.");