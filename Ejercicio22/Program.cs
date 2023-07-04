//Ingresar 2 valores y determinar el menor de ellos. (Nota: con ? devolver el valor en una variable o directo en WriteLine).

Console.WriteLine("Ingrese un numero.");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un numero.");
int n2 = int.Parse(Console.ReadLine());
int menor = (n1<n2)? n1 : n2;
Console.WriteLine($"{menor}");