using System;
using tarea3._2;

namespace tarea3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma: {calc.Sumar(num1, num2)}");
            Console.WriteLine($"Resta: {calc.Restar(num1, num2)}");
            Console.WriteLine($"Multiplicación: {calc.Multiplicar(num1, num2)}");
            Console.WriteLine($"División: {calc.Dividir(num1, num2)}");
        }
    }
}
