//Mostrar la superficie de un rectángulo ingresando la base y la altura. (Nota: la superficie de un rectángulo es base * altura).

Console.WriteLine("Ingrese la base.");
double basee = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura.");
double altura = double.Parse(Console.ReadLine());
double superficie = basee * altura;
Console.WriteLine($"Superficie: {superficie}");