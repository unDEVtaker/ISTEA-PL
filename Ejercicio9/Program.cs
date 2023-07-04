// /1. Ingresar 2 valores y determinar el menor de ellos.
Console.WriteLine("ingrese el primer valor.");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese el segundo valor.");
double num2 = double.Parse(Console.ReadLine());
if(num1>num2){
    Console.WriteLine($"{num1} es mayor que {num2}");
}else if(num1==num2){
    Console.WriteLine($"{num1} es igual a {num2}");
}else{
    Console.WriteLine($"{num2} es mayor {num1}");
}
