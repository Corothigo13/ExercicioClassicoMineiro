using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classico_Mineiro.Classico.Questao02
{
    class VCruzeiro
    {
        public int derrota(int gol1,int gol2,int derrota)
        {
            int fail;
            fail = derrota;
            fail++;
            Console.WriteLine("Uma vitoria por " + gol1 + " a " + gol2 + " contabilizada para o Cruzeiro.");
            return fail;
        }
    }
}
