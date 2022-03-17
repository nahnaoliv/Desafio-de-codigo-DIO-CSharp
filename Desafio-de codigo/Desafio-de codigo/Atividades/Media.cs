using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_codigo.Atividades
{
    public class Media
    {
        public Media()
        {
            double A, B, C, MEDIA;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            MEDIA = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;
            Console.WriteLine("MEDIA = {0:F1}", MEDIA);
            Console.ReadKey();
        }
    }
}
