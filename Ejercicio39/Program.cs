//El supermercado atiende 50 personas todos los días como máximo. Cuando las personas llegan se les asigna un número. Al llegar a las 50, se les pide a las próximas que vengan al día siguiente y se anota en un papel cuántas personas quedaron sin atender. El dueño quiere un sistema de estadísticas y para empezar solicitó dijo que cada domingo va a ingresar por sistema cuántas personas vinieron desde el domingo anterior es decir, que va a cargar desde el domingo anterior al sábado siguiente. Y necesita saber:
//a. Cuántas personas quedaron sin atender al finalizar la semana.
//b. Cuántos días en total llegaron o superaron las 50 personas.
//c. Cuántos días no llegaron a las 50 personas.
int limiteClientes=50;
int cantClientes;
int sinAtender;
int cont =0;
int clientesTotales =0;
int clientesSinAtender =0;
int dias50=0;
int diasMenos50=0;


for (int i = 1; i <=7; i++)
{
    Console.WriteLine($"Ingrese los clientes del dia {i}:");
    cantClientes = int.Parse(Console.ReadLine());
    if(cantClientes>limiteClientes){
        sinAtender= cantClientes - limiteClientes;
        clientesSinAtender +=sinAtender;
        dias50++;
    }
    else{
        diasMenos50++;
    }
    clientesTotales +=cantClientes;
}
Console.WriteLine($"Clientes sin atender en la semana: {clientesSinAtender}");
Console.WriteLine($"Cantidad de dias con 50 clientes o mas: {dias50}");
Console.WriteLine($"Cantidad de dias con menos de 50 clientes: {diasMenos50}");