using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classico_Mineiro.Classico.Questao02
{
    class Empate
    {
        public int empate(int gol1, int gol2,int empate)
        {
            int draw = empate;
            draw++;
            Console.WriteLine("Um empate por " + gol2 + " a " + gol1 + " contabilizado.");
            return draw;
        }
    }
}
