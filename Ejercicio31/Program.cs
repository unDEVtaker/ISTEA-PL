//for Solicitar un valor y luego mostrar todos los múltiplos de 5 desde 1 hasta ese valor.
int num;
int cont =0;
Console.WriteLine("Ingrese un numero.");
num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++){
    if(i%5==0){
        Console.WriteLine($"{i} es multiplo de 5.");
        cont++;
    }
}
Console.WriteLine($"Cantidad de multiplos de 5 ingresados: {cont}");