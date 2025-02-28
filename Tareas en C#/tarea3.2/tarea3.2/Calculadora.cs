using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3._2
{
    internal class Calculadora
    {
        public int Sumar(int a, int b) => a + b;
        public int Restar(int a, int b) => a - b;
        public int Multiplicar(int a, int b) => a * b;
        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return 0;
            }
            return a / b;
        }
    }
}
