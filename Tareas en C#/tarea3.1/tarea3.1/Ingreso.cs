using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea3._1;

namespace tarea3._1
{
    class Ingreso
    {
        public static double PedirIngreso(int mes)
        {
            Console.Write($"Mes {mes}: ");
            return double.Parse(Console.ReadLine());
        }
    }

}
