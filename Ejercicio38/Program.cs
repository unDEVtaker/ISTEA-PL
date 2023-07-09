//El almacén del barrio quiere un pequeño sistema que le permita saber el vuelto exacto a entregar. El requerimiento es:
//a. Que pueda ingresar el valor de cada producto y la cantidad.
//b. Con cero devuelve el total.
//c. Ingresar con cuánto abona el cliente y mostrar el vuelto.
double cantProducto;
double precioProducto;
double pagoCliente;
double vueltoCliente;
double total = 0;
int menu;

Console.WriteLine("Sistema de cobro.");
do{
    Console.WriteLine("Ingresa cantidad del producto.");
    cantProducto = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa el precio del producto.");
    precioProducto = int.Parse(Console.ReadLine());
    total += cantProducto*precioProducto;
    Console.WriteLine("Siguiente producto(1) o Teminar(0)");
    menu = int.Parse(Console.ReadLine());
}
while(menu != 0 );
if(menu == 0){
    Console.Write($"El total es ${total}.");
    Console.Write("Con cuanto abona el cliente? :");
    pagoCliente=int.Parse(Console.ReadLine());
    vueltoCliente = pagoCliente - total ;
    Console.WriteLine($"El vuelto es ${vueltoCliente}");
}
