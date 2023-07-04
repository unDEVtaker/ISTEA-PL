//Dado un valor de un sueldo, mostrar el resultado de incrementar un 10%. (Nota: utilizar double.Parse() pues son números con decimales).

Console.WriteLine("Ingrese un sueldo.");
double sueldo = double.Parse(Console.ReadLine());
double incre = sueldo * 1.10;
Console.WriteLine($"El sueldo con un incremento de 10%: {incre} ");