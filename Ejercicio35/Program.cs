//El servicio meteorológico necesita mostrar la cantidad de días que no llovió de acuerdo a los datos que les entregaron. Realice un programa en el que ingresen la cantidad de días a procesar, la cantidad de lluvia para cada día y mostrar la cantidad de días que no llovió (el valor ingresado es cero).
int cont =0;
int lluvia;
int dias;
int sumaLluvia=0;
int contSinLluvia=0;
int contConLluvia=0;
Console.WriteLine("Detalle de lluvias.");
Console.Write("Dias utilizados para la muestra: ");
dias = int.Parse(Console.ReadLine());
for (int i = 1; i <= dias; i++){
    Console.Write($"Ingrese la lluvia del dia {i}: ");
    lluvia = int.Parse(Console.ReadLine());
    if(lluvia!=0){
        sumaLluvia+=lluvia;
        contConLluvia++;
    }
    else{
        contSinLluvia++;
    }
    cont++;
    }
Console.WriteLine($"Muestra de {cont} dias: ");
Console.WriteLine($"Dias con lluvia: {contConLluvia}");
Console.WriteLine($"Cantidad de lluvia: {sumaLluvia}mm");
Console.WriteLine($"Dias sin lluvia: {contSinLluvia}");