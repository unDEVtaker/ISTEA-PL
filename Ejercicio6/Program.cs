//Ingresar la cantidad de horas que trabaja un obrero al mes y el valor de lo que gana por hora y finalmente mostrar cual es el sueldo que tiene que cobrar.

Console.WriteLine("Ingrese las horas trabajadas.");
double horas = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de la hora.");
double valorHora = double.Parse(Console.ReadLine());
double sueldo = horas* valorHora;
Console.WriteLine($"Sueldo empleado: {sueldo}");

