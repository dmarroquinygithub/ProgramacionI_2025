using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea3._5;    
namespace tarea3._5
{
    public class ComprobarPuntuacion
    {
        private int highScore = 0;
        private string recordHolder = "Nadie";
        public void ComprobarNuevaPuntuacion(int score, string player)
        {
            if (score > highScore)
            {
                highScore = score;
                recordHolder = player;
                Console.WriteLine("La nueva puntuación más alta es " + highScore);
                Console.WriteLine("La puntuación más alta fue lograda por " + recordHolder);
            }
            else
            {
                Console.WriteLine("La puntuación más alta de " + highScore + " no se ha podido superar, y aún está en manos de " + recordHolder);
            }
        }
    }
}
