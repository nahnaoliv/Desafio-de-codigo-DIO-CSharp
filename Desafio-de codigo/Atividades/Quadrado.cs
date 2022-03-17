using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_codigo.Atividades
{
    public class Quadrado
    {
        public Quadrado()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + i * i + " " + i * i * i + " ");
            }
        }
    }
}
