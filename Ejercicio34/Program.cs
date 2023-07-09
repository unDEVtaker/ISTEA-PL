//Solicitar por pantalla la nota final de cada alumno y devolver el promedio de las calificaciones.
Console.WriteLine("Cargar notas finales.");
Console.Write("Cantidad de Alumnos:");
int nota;
int pro;
int sum =0;
int cont =0;
int alum = int.Parse(Console.ReadLine());
for (int i = 1; i <= alum; i++)
{
    Console.Write($"Ingrese la Nota del alumno {i}:");
    nota = int.Parse(Console.ReadLine());
    sum+=nota;
    cont++;
}
pro=sum/cont;
Console.WriteLine($"El primedio de las notas es: {pro}");