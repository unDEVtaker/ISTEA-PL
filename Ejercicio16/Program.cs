
using System;
using System.Collections;
//Escribir por pantalla el día de la semana e informar el número de día (Domingo es 1,lunes es 2...).
Console.WriteLine("Ingrese el dia.");
string dia = Console.ReadLine();
int num;
switch(dia.ToLower())
{
    case "domingo":
        num = 1;
        break;
    case "lunes":
        num = 2;
        break;
    case "martes":
        num = 3;
        break;
    case "miercoles":
        num = 4;
        break;
    case "jueves":
        num = 5;
        break;
    case "viernes":
        num = 6;
        break;
    case "sabado":
        num = 7;
        break;
    default:
        Console.WriteLine("numero invalido");
        return;
}
Console.WriteLine($"{dia} corresponde al numero de dia {num}");