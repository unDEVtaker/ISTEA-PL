//Armar un menú tal que según el número ingresado realice las siguientes acciones:
//a. 1: Pida un valor entre 1 y 10 e indique si es par o no.
//b. 2: Pida dos números y muestre el menor de los dos.\

Console.WriteLine("Seleccion 1 o 2.");
int opc = int.Parse(Console.ReadLine());
int n1, n2;
switch(opc)
{
    case 1:
        Console.WriteLine("Ingrese un  valor entre 1 y 10.");
        n1 = int.Parse(Console.ReadLine());
        if(n1>=1 && n1<=10){
            if(n1%2 ==0){
                Console.WriteLine("El numero es par.");
            }
            else{
                Console.WriteLine("El numero es impar.");
            }
        }
        else{
            Console.WriteLine("El valor ingresedo no es valido.");
        }
        break;
    case 2:
        Console.WriteLine("Ingrese un numero");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        n2 = int.Parse(Console.ReadLine());        
        int menor = (n1 <n2)? n1 :n2;
        Console.WriteLine($"{menor} es el menor de los dos numeros.");
        break;
    case 3:
        Console.WriteLine("Opcion no validad.");
        break;
}

