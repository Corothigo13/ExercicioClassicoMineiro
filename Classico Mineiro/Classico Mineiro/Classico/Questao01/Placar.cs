using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classico_Mineiro.Classico.Questao01
{
    class Placar
    {
        int vitoriasG=0, derrotasG=0, empatesG = 0, novoj=0;
        public void placar(int gol1, string time1, int gol2, string time2, int vitoriasG, int derrotasG, int empatesG)
        {
            if (time1.ToUpper() == "ATLETICO")
            {
                if (gol1 > gol2)
                {
                    VitoriaGalo v = new VitoriaGalo();
                    vitoriasG = v.vitoria(gol1, gol2, vitoriasG);
                }
                else if (gol2 > gol1)
                {
                    DerrotaGalo d = new DerrotaGalo();
                    derrotasG = d.derrota(gol2, gol1, derrotasG);
                }
                else
                {
                    Empate e = new Empate();
                    empatesG = e.empate(gol2, gol1,empatesG);
                }
            }
            if(time1.ToUpper() == "CRUZEIRO")
            {
                if (gol2 > gol1)
                {
                    VitoriaGalo v = new VitoriaGalo();
                    vitoriasG = v.vitoria(gol1, gol2,vitoriasG);
                }
                else if (gol1 > gol2)
                {
                    DerrotaGalo d = new DerrotaGalo();
                    derrotasG = d.derrota(gol2, gol1,derrotasG);
                }
                else
                {
                    Empate e = new Empate();
                    empatesG = e.empate(gol2, gol1,empatesG);
                }
            }

            Console.WriteLine("Deseja um novo jogo?\n1- Sim\n2-Não");
            novoj = int.Parse(Console.ReadLine());
            if (novoj == 1)
            {
                Console.Clear();
                Teste t = new Teste();
                t.rodar(vitoriasG, derrotasG, empatesG);

            }
            else
            {
                Console.WriteLine("Foram realizados "+ (empatesG+derrotasG+vitoriasG)+ " jogos.");
                Console.WriteLine("O Atletico venceu "+vitoriasG +" jogos.");
                Console.WriteLine("O Cruzeiro venceu " + derrotasG + " jogos.");
                Console.WriteLine("Teve um total de "+empatesG+" empates.");
                if(vitoriasG>derrotasG)
                {
                    Console.WriteLine("O Atletico venceu mais jogos. S2");
                }
                else if(vitoriasG<derrotasG)
                {
                    Console.WriteLine("O Cruzeiro venceu mais jogos.");

                }
                else
                {
                    Console.WriteLine("Não houve um time que ganhou mais.");
                }
            }
        }
    }
}
