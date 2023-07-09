//while Indicar si el usuario alguna vez en el ciclo ingresó el valor 10. Se sale con 0.
int valor = 0;
int cuenta = 0;
bool usoDiez = false;


while (true)
{
    Console.WriteLine("Ingrese un numero: ");
    valor = int.Parse(Console.ReadLine());
    if(valor ==0)break;
    if(valor ==10){
        cuenta++;
        usoDiez=true;
    }
}
if(usoDiez == true){
    Console.WriteLine($"Ingreso el numero 10 {cuenta} veces.");
}