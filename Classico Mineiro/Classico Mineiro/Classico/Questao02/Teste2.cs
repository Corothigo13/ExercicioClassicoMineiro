using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classico_Mineiro.Classico.Questao02
{
    class Teste2
    {
        public void rodar(int vitoriasG, int derrotasG, int empatesG, int Wamerica)
        {
            int time1, time2, gol1, gol2;
            Console.WriteLine("Por favor escolha o primeiro time: \n1- Atletico\n2- Cruzeiro\n3- America");
            time1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos gols o time fez?");
            gol1 = int.Parse(Console.ReadLine());

            Placar p = new Placar();

            if (time1 == 1)
            {
                Console.WriteLine("Por favor escolha o segundo time: \n1- Cruzeiro\n2- America");
                time2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantos gols ele fez?");
                gol2 = int.Parse(Console.ReadLine());

                if (time2 == 1)
                {
                    p.placar(gol1, "Atletico", gol2, "Cruzeiro", vitoriasG, derrotasG, empatesG,Wamerica);
                }
                if (time1 == 2)
                {
                    p.placar(gol1, "Atletico", gol2, "America", vitoriasG, derrotasG, empatesG,Wamerica);

                }
            }
            if (time1 == 2)
            {

                Console.WriteLine("Por favor escolha o segundo time: \n1- Atletico\n2- America");
                time2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantos gols ele fez?");
                gol2 = int.Parse(Console.ReadLine());
                if (time2 == 1)
                {
                    p.placar(gol1, "Cruzeiro", gol2, "Atletico", vitoriasG, derrotasG, empatesG,Wamerica);
                }
                if (time1 == 2)
                {
                    p.placar(gol1, "Cruzeiro", gol2, "America", vitoriasG, derrotasG, empatesG,Wamerica);

                }
            }
            if (time1 == 3)
            {
                Console.WriteLine("Por favor escolha o segundo time: \n1- Atletico\n2- Cruzeiro");
                time2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantos gols ele fez?");
                gol2 = int.Parse(Console.ReadLine());
                if (time2 == 1)
                {
                    p.placar(gol1, "America", gol2, "Atletico", vitoriasG, derrotasG, empatesG,Wamerica);
                }
                if (time1 == 2)
                {
                    p.placar(gol1, "America", gol2, "Cruzeiro", vitoriasG, derrotasG, empatesG,Wamerica);

                }
            }
        }
    }
}
