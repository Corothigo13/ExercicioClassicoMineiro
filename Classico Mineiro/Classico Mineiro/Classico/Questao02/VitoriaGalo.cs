using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classico_Mineiro.Classico.Questao02
{
    class VitoriaGalo
    {
        public int vitoria(int gol1, int gol2, int vitoria)
        {
            int win = vitoria;
            win++;
            Console.WriteLine("Uma vitoria por " + gol1 + " a " + gol2 + " contabilizada para o Atletico.");
            return win;
        }
    }
}
