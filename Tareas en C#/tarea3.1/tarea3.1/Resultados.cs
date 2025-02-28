using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using tarea3._1;

namespace tarea3._1
{
    class Resultado
    {
        public static void MostrarResultados(string usuario, double ingreso1, double ingreso2, double ingreso3)
        {
            double suma = ingreso1 + ingreso2 + ingreso3;
            double promedio = suma / 3;

            CultureInfo culturaGTQ = new CultureInfo("es-GT");

            Console.WriteLine($"Hola {usuario}, en total ganaste {suma.ToString("C", culturaGTQ)} y promediaste {promedio.ToString("C", culturaGTQ)}.");
        }
    }
}
