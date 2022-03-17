using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_codigo.Atividades
{
    public class Pneu
    {
        public Pneu()
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());

            int DIFERENCA = A - B;
            Console.WriteLine(DIFERENCA);
        }
    }
}
