//Repetir el ejercicio para los números impares. Sumar todos los valores que hayan sido pares.
int num;
int cont=0;
int suma =0;
Console.WriteLine("Ingrese un numero.");
num=int.Parse(Console.ReadLine());
for (int i = 0; i <= num; i++){
    if(i%2!=0){
        Console.WriteLine($"{i} es impar");
        suma+=i;
        cont++;
    }
}
Console.WriteLine($"Cantidad de impares ingresados: {cont}");
Console.WriteLine($"La suma es: {suma}");