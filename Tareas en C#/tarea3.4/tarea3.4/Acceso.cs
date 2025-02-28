using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea3._4;

namespace tarea3._4
{
    internal class Acceso
    {
        public static void Acceso1() {
            Console.WriteLine("Inicio de Sesión");
            Console.Write("Ingrese su nombre de usuario: ");
            string username = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            string password = Console.ReadLine();

            if (username == Program.registeredUsername && password == Program.registeredPassword)
            {
                Console.WriteLine("Inicio de sesión exitoso! Bienvenido, " + username + ".");
            }
            else
            {
                Console.WriteLine("Error: Nombre de usuario o contraseña incorrectos.");
            }
        }
    }
}
