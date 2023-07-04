//Sabiendo que 1 es domingo, 2 es lunes, hasta 7 que es sábado, armar un programa que indique qué día es según el número ingresado.

Console.WriteLine("Ingrese un numero del 1 al 7.");
int num = int.Parse(Console.ReadLine());
string dia;
switch(num){
    case 1:
        dia = "Domingo";
        break;
    case 2:
        dia = "Lunes";
        break;
    case 3:
        dia = "Martes";
        break;
    case 4:
        dia = "Miercoles";
        break;
    case 5:
        dia = "jueves";
        break;
    case 6:
        dia = "Viernes";
        break;
    case 7:
        dia = "Sabado";
        break;
    default:
        dia = "Numero Invalido";
        break;
}
if(dia=="Numero Invalido"){
    Console.WriteLine("Numero Invalido");
}
else{
Console.WriteLine($"{num} corresponde a el dia {dia}.");
}