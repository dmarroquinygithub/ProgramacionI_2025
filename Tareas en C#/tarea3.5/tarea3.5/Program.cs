using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ComprobarPuntuacion juego = new ComprobarPuntuacion();

                juego.ComprobarNuevaPuntuacion(50, "Darvin");
                juego.ComprobarNuevaPuntuacion(30, "Ana");
                juego.ComprobarNuevaPuntuacion(100, "Luis");
                juego.ComprobarNuevaPuntuacion(90, "María");
        }
    }
}
