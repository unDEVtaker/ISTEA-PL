//Ingresar un número y determinar si es mayor a 10 y si es par.
Console.WriteLine("Ingrese un numero.");
double num1 = double.Parse(Console.ReadLine());
if(num1 >10){
    Console.WriteLine($"{num1} es mayor a 10");
}
else{
Console.WriteLine($"{num1} no es mayor a 10");
}
if((num1%2)==0){
    Console.WriteLine($"{num1} es par");
}else{
    Console.WriteLine($"{num1} no es par");
}