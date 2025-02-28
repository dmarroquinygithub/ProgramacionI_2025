using System;
using tarea3._1;
class Program
{
    // Crear un método static, que pida los ingresos de los últimos 3 meses,
    // así como el nombre del usuario e imprima en pantalla la suma de todos
    // los ingresos y un promedio con un mensaje similiar a "Hola <usuario>
    // en total ganaste suma y promediaste promedio ". 

    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese sus ingresos de los últimos 3 meses:");

        double ingreso1 = Ingreso.PedirIngreso(1);
        double ingreso2 = Ingreso.PedirIngreso(2);
        double ingreso3 = Ingreso.PedirIngreso(3);

        Resultado.MostrarResultados(nombre, ingreso1, ingreso2, ingreso3);
    }
}
