//Ingresar dos valores y obtener la parte entera y el resto de la división.

Console.WriteLine("Ingrese numero1:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese numero2:");
double num2 = double.Parse(Console.ReadLine());
if(num2 !=0){
    double div = num1 / num2;
    double resto = num1 % num2;
    Console.WriteLine($"La division es: {div}");
    Console.WriteLine($"El resto es: {resto}");
}
else{
    Console.WriteLine("No se puede dividir por 0.");
}