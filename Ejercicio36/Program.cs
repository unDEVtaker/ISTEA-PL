//Solicitar la cantidad de remeras confeccionadas. Luego en un ciclo ingresar cuántos metros de hilos se usaron para cada una y obtener el total de hilo utilizado.
int remeras =0;
int mts =0;
int sumMetros =0;
int cont =0;

Console.Write("Ingrese la cantidad de remeras: ");
remeras = int.Parse(Console.ReadLine());
for (int i = 1; i <= remeras; i++)
{
    Console.Write($"Mts remera {i}: ");
    mts = int.Parse(Console.ReadLine());
    sumMetros+=mts;
    cont++;
}
Console.WriteLine($"La cantidad de metros utilizados: {sumMetros}mts");
