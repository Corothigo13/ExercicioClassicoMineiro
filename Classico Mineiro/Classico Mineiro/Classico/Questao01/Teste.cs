using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classico_Mineiro.Classico.Questao01
{
    class Teste
    {
        public void rodar(int vitoriasG, int derrotasG, int empatesG)
        {
            int time1, gol1, gol2;
            Console.WriteLine("Por favor escolha o primeiro time: \n1- Atletico\n2- Cruzeiro");
            time1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos gols o time fez?");
            gol1 = int.Parse(Console.ReadLine());
            Console.WriteLine("E  outro time?");
            gol2 = int.Parse(Console.ReadLine());

            Placar p = new Placar();

            if (time1 == 1)
            {
                p.placar(gol1, "Atletico", gol2, "Cruzeiro", vitoriasG, derrotasG, empatesG);
            }
            if (time1 == 2)
            {
                p.placar(gol1, "Cruzeiro", gol2, "Atletico", vitoriasG, derrotasG, empatesG);
            }
        }
    }
}
