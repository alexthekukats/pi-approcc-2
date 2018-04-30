using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 4;
            double i = 0;
            double num = 3;

            while (true) //Leibniz-féle sor kicsit másképp //nagyon lassú
            {
                if ((i % 2) == 0)
                {
                    pi = pi - (4 / num);
                }
                else
                {
                    pi = pi + (4 / num);
                }

                num = num + 2;
                i++;
                    Console.WriteLine(pi);

                    //Console.ReadKey();
            }
        }
    }
}
