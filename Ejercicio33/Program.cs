//for Pedir un valor y un nombre por pantalla. Mostrar por pantalla el nombre tantas veces como el valor indicado.
int num;
string nombre;

Console.WriteLine("Ingrese un nombre:");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese un numero.");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i}- {nombre}");
}