//Ingresar un número y determinar si es menor a 50 y si es divisible por 5. (Nota: es divisible por 5 si el resto por dividir por 5 da 0).
Console.WriteLine("Ingresar un numero.");
int num1 = int.Parse(Console.ReadLine());
if(num1 <50){
    Console.WriteLine($"{num1} es menor a 50.");
}
else{
    Console.WriteLine($"{num1} es amyor  o igual a 50.");
}
if((num1%5==0)){
    Console.WriteLine($"{num1} es divisible por 5.");
}
else{
    Console.WriteLine($"{num1} no es divisible por 5.");
}