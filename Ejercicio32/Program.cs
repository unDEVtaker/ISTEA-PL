//for Pedir un valor por pantalla e imprimir todos los pares.
int num;
int cont =0;
Console.WriteLine("Ingrese un numero.");
num = int.Parse(Console.ReadLine());
for (int i = 0; i <= num; i++)
{
    if(i%2==0)Console.WriteLine($"{i} es par.");
}