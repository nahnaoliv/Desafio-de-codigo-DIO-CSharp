using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_codigo.Atividades
{
    public class Pum
    {
        public Pum()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N * 4; i += 4)
            {

                Console.WriteLine(i + " " + (i + 1) + " " + (i + 2) + " PUM");
            }
        }
    }
}
