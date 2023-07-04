using System;
// /Dado dos valores, indicar por pantalla el producto, la suma e informar por pantalla quién es el más alto. (Nota: Intentar resolver con double, y en el ingreso por teclado revisar los resultados cuando el símbolo decimal es con , “coma” o . “punto”).
double n1=10 , n2=100, mult=n1*n2, sum = n1+n2;

Console.WriteLine($"La suma de {n1} y {n2} = {sum}");
Console.WriteLine($"EL producto de {n1} y {n2} = {mult}");
if(n1>n2){
    Console.WriteLine($"{n1} es mayor que {n2}");
}
else if(n1<n2){
    Console.WriteLine($"{n2} es mayor que {n1}");
}
else{
    Console.WriteLine($"{n2} y {n1} son iguales.");
}