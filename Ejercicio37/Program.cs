//Hacer un programa para que se pida cuántas personas se van a ingresar y luego el sexo (F - Femenino / M - Masculino de los alumnos de un curso).
//Mostrar la siguiente información por pantalla
//a. Cuántos alumnos hay.
//b. Cuántas mujeres, y cuántos varones hay.
using System;
using System.Text.RegularExpressions;
int cantPersonas =0;
int sexoF =0;
int sexoM =0;
int cont=0;
string sexo;
string checkEdad;

Console.Write("Cantidad de personas: ");
cantPersonas = int.Parse(Console.ReadLine());
for (int i = 1; i <=cantPersonas; i++){
    do{
        Console.Write($"Ingrese el sexo de la persona {i}: ");
        sexo = Console.ReadLine().ToUpper();
        if (sexo != "F" && sexo!= "M"){
            Console.WriteLine($"Sexo invalido {sexo}, intente nuevamente: F/M?");
        }
    }
    while(sexo!= "F" && sexo!= "M");
    if(sexo== "F"){
        sexoF++;
    }
    if(sexo== "M"){
        sexoM++;
    }
    cont++;
}
    
Console.WriteLine($"Cantidad de alumnos: {cont}");
Console.WriteLine($"Cantidad sexo femenino: {sexoF}");
Console.WriteLine($"Cantidad sexo masculino: {sexoM}");