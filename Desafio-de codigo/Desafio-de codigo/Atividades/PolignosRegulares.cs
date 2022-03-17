using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_codigo.Atividades
{
    public class PolignosRegulares
    {
        public PolignosRegulares()
        {
            string[] v = Console.ReadLine().Split();
            double a = Convert.ToDouble(v[0]);
            double b = Convert.ToDouble(v[1]);

            double p = (a * b);

            Console.WriteLine("" + p);
        }
    }
}
