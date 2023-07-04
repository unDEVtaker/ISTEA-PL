//Ingresar el sueldo de una persona y luego mostrar una leyenda que diga “recibe aumento” siempre y cuando su sueldo sea menor o igual a 30000 si no, mostrar un mensaje que diga “no recibe aumento”.

Console.WriteLine("Ingrese el sueldo.");
double sueldo = double.Parse(Console.ReadLine());
if(sueldo <=30000){
    Console.WriteLine("Recibe aumento.");
}
else{
    Console.WriteLine("No recibe aumento.");
}