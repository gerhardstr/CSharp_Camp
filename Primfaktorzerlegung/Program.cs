using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primfaktorzerlegung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein: \n");
            long number = Convert.ToInt64(Console.ReadLine());
            long numberOld = 0;

            var primefactor = new StringBuilder();

            if (number == 1)
            {
                Console.WriteLine("Die Zahl ist nicht mehr teilbar, da sie bereits 1 ist.");
            }
            else
            {
                while (number % 2 == 0) // can be divided without residual value
                {
                    numberOld = number; // keep value
                    number = number / 2; // 
                    primefactor.Append(2);
                    Console.WriteLine($"{numberOld} / " + 2 + " = " + number);
                }
                for (long i = 3; i <= number; i = i + 2)
                    while (number % i == 0)
                    {
                        numberOld = number;
                        number = number / i;
                        primefactor.Append(i);
                        Console.WriteLine($"{numberOld} / "+ i + " = " + number);
                    }
                Console.WriteLine($"Primfaktoren: {primefactor}");
            }
            Console.ReadKey();
        }
    }
}
