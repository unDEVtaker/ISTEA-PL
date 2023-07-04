//Ingresar tres sueldos y mostrar la suma de todos.

Console.WriteLine("Ingrese sueldo.");
double sueldo1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese sueldo.");
double sueldo2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese sueldo.");
double sueldo3 = int.Parse(Console.ReadLine());
double suma = sueldo1 + sueldo2 + sueldo3;
Console.WriteLine($"suma de los sueldos: {suma}");
