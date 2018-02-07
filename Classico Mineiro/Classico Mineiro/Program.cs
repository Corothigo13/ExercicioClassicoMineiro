using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classico_Mineiro.Classico.Questao01;
using Classico_Mineiro.Classico.Questao02;

namespace Classico_Mineiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int e;
            Console.WriteLine("Por favor escolha qual questao rodar:\n1- Para Qustao 01\n2- Para questao 02");
            e=int.Parse(Console.ReadLine());
            if(e==1)
            {
            Teste t = new Teste();
            t.rodar(0,0,0);
            }
            if (e == 2)
            {
                Teste2 t2 = new Teste2();
                t2.rodar(0, 0, 0,0);
            }
            Console.ReadKey();
        }
    }
}
