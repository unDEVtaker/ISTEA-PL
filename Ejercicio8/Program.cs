//Pedir el nombre, la edad e informar por pantalla “En 10 años (nombre) va a tener X años”.

Console.WriteLine("Ingrese su edad.");
int edad = int.Parse(Console.ReadLine());
int edadFut = edad + 10;
Console.WriteLine($"Su edad en 10 años sera: {edadFut}");
