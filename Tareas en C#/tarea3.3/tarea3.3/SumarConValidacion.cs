using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea3._3;

namespace tarea3._3
{
    internal class SumarConValidacion
    {
        public static void SumarValidacion() 
        {
            try
            {
                Console.Write("Ingrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                int suma = num1 + num2;
                Console.WriteLine($"La suma es: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar un número válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Fin del proceso.");
            }
        }
    }
}
