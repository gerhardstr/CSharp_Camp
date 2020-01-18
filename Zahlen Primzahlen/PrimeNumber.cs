using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenberechnungen
{
    public class PrimeNumber
    {
 
        public PrimeNumber(int number)
        {
            calcPrim(number);
        }

        public void calcPrim(int number)
        {
            

            for (int i = 2; i <= number; i++) // numbers from 2 to user input
            {
                bool prim = true;
                {
                    for (int j = 2; j<i; j++)
                    {
                        if (i%j == 0) // division with no residual value
                        {
                            prim = false;
                            break;
                        }
                    }
                }
            if (prim == true)
                {
                    Console.WriteLine($"Die nächste Primzahl: {i}");
                }
            }
            Console.WriteLine("Taste drücken...");
            Console.ReadKey();
        }
    }
}
