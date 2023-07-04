//Armar un programa que permita ingresar dos números que representan la cantidad de litros que han utilizado para llenar sus piletas de lona. Determinar quién utilizó más agua.

Console.WriteLine("Ingres los lts de la primer pileta.");
double p1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingres los lts de la segunda pileta.");
double p2 = double.Parse(Console.ReadLine());
if(p1>p2){
    Console.WriteLine("La pileta 1 uso mas litros que la pileta 2");
}
else if(p1<p2){
    Console.WriteLine("La pileta 2 uso mas litros que la pileta 1");
}
else{
    Console.WriteLine("Usaron la misma cantidad de lts.");
}