//for. Solicitar por pantalla un número e informar por pantalla los números pares desde 0 hasta el valor ingresado.

int num;
int contador =0;
Console.WriteLine("Ingrese un numero.");
num = int.Parse(Console.ReadLine());
for (int i = 0; i <= num; i++){
    if(i%2==0){
        Console.WriteLine($"{i} es par.");
    }
    contador++;
}