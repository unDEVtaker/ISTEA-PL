using System;
//Ingresar por pantalla un número entre 0 y 99. Informar si el número tiene un dígito o dos.

Console.WriteLine("Ingrese un numero entre  0 y 99.");
int num = int.Parse(Console.ReadLine());
if(num >=100){
    Console.WriteLine($"{num} no es un numero entre 0 y 99");
}
else if(num >=0 && num <10){
    Console.WriteLine($"{num} es un numero de un digito");
}
else{
    Console.WriteLine($"{num} es un numero de dos digitos.");
}