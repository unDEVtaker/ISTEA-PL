//while Crear un programa que permita ingresar al usuario valores distintos de cero (pueden ser negativos o positivos). Contar cuántos son pares. Se sale con 0.
int valor =0;
int par = 0;
int suma=0;

while (true)
{
    Console.Write("Ingrese un valor: ");
    valor = int.Parse(Console.ReadLine());
        if(valor ==0)
        break;
        if(valor%2==0 ){
        par++;
        suma +=valor;
        }

}
Console.WriteLine($"Los cantidad de numeros pares ingresados es {par} y la suma es: {suma}");
