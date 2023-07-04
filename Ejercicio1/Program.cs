//1. Pedir la dirección, la altura y la localidad en tres variables distintas. Mostrar por pantalla lo ingresado por el usuario en una sola frase. (Nota: Utilice { } o el operador+).

Console.WriteLine("Ingrese su direccion: ");
string dire = Console.ReadLine();
Console.WriteLine("Ingrese su altura: ");
string alt = Console.ReadLine();
Console.WriteLine("Ingrese su localidad: ");
string loc = Console.ReadLine();

Console.WriteLine($"Su direccion es: {dire} {alt} {loc}");