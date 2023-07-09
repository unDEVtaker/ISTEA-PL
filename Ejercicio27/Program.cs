//While Armar un programa para informar por pantalla cuando el valor que ingresó el usuarioes impar. Se sale con 0.
int valor =0;

while (true)
{
    Console.WriteLine("Ingrese un numero, para definir si es par o impar o 0 para salir.");
    valor = int.Parse(Console.ReadLine());
    if(valor ==0)
    break;
    if(valor%2!=0)Console.WriteLine($"{valor} es impar.");
}