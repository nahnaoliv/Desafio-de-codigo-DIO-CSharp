using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_codigo.Atividades
{
    public class Tabuada
    {
        public Tabuada()
        {
            int n = 150; //int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int cont = n * i;
                Console.WriteLine(string.Format("{0} x {1} = {2}", i, n, cont));
            }
        }
    }
}
