//While - Ingresar varios valores mayores que cero y devolver la suma..se sale con 0.

int valor;
int suma =0;

Console.WriteLine("Ingrese valores mayores a 0. Ingrese 0 para salir.");
while (true)
{
    Console.Write("Ingrese un valor.");
    valor = int.Parse(Console.ReadLine());
    if(valor == 0)
        break;
    if(valor <0 )
        continue;
    suma+= valor;
}
Console.WriteLine($"La suma es de los valores es: {suma}");
