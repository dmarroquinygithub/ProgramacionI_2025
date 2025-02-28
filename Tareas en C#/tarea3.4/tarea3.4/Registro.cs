using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea3._4;

namespace tarea3._4
{
    internal class Registro
    {
        public static void Registro1()
        {
            Console.WriteLine("Registro de Usuario");
            Console.WriteLine("Ingrese un nombre de usuario: ");
            Program.registeredUsername = Console.ReadLine();

            Console.WriteLine("Ingrese una contraseña: ");
            Program.registeredPassword = Console.ReadLine();
        }
    }
}
