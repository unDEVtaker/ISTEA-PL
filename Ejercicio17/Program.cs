//Ingresar un número y luego mostrarlo por pantalla solo si es positivo o negativo. Utilizar if. (Nota: Revisar si es necesario indicar bloques de sentencia, es decir { } ).

Console.WriteLine("Ingrese un numero.");
int n = int.Parse(Console.ReadLine());
if(n>0 || n<0){
    Console.WriteLine($"{n}");
}