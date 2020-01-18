using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenberechnungen
{
    class AbudantNumber
    {
        public AbudantNumber()
        {
            calcAbudant();
        }
        public void calcAbudant()
        {

            int result = 0;

            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        result += j;

                    /* Example
                     * i = 15
                     * j = 1 
                     * 15 / 1 = 15 = true (0 Rest)
                     * result = 0 + 1
                     * ...
                     * j = 3
                     * 15 / 3 = 5 = true (0 Rest)
                     * result = 1 + 3
                     * ...
                     */
                }

                if (result == i)
                    Console.WriteLine($"{i} ist eine vollkommene Zahl.");
                else if (result > i)
                    Console.WriteLine($"{i} ist eine abudante Zahl.");

                result = 0;
            }

            Console.WriteLine("Taste drücken...");
            Console.ReadKey();

        }
    }
}
