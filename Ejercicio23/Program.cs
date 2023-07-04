//Ingresar un número y determinar si es mayor a 10 y si es par.

Console.WriteLine("Ingrese un numero");
int n= int.Parse(Console.ReadLine());

string mayor = (n>10)? "es mayor a 10" : "es menor a 10";
string par = (n%2 ==0)? "es par.":"no es par.";

Console.WriteLine($"{n} {mayor} y {par}");