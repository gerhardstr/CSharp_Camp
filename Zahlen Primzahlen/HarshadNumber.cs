using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenberechnungen
{
    class HarshadNumber
    {
        public HarshadNumber()
        {
            calcHarshad();
        }
        public void calcHarshad()
        {       
            int result = 0;
            int j = 0;

            for (int i = 1; i <= 1000; i++)
            {
                j = i; // keep value i
                while (j > 0)
                {
                    result = result + (j % 10); 
                    j /= 10;

                    /* example
                     * i = 723
                     * j = 723
                     * 723 % 10 = 3
                     * 723 / 10 = 72,3 (int cut ,3)
                     */                   
                }

                if(i%result == 0)
                    Console.WriteLine($"Die nächste Harshad-Zahl lautet: {i}");
                result = 0;
            }

            Console.WriteLine("Taste drücken...");
            Console.ReadKey();
        }
    }
}
