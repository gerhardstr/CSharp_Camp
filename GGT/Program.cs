using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGT
{
    class Program
    {
        static void Main(string[] args)
        {
            long primeNumber;
            long primeNumber1;
            long primeNumber2;

            Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            PrimeNumberDecomposition(number1, out primeNumber1);

            Console.WriteLine("Bitte geben Sie eine weitere Zahl ein: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            PrimeNumberDecomposition(number2, out primeNumber2);

            Console.WriteLine($"Primzahlzerlegung der Zahl {number1} ergibt: {primeNumber1}");
            Console.WriteLine($"Primzahlzerlegung der Zahl {number2} ergibt: {primeNumber2}");

            CalculateGGT(ref number1, ref number2);

            Console.WriteLine("Der GGT der beiden Zahlen beträgt " + number1);
            Console.ReadKey();

        }

        private static void CalculateGGT(ref int number1, ref int number2)
        {
            if (number1 == number2)
            {
                Console.WriteLine($"Beide Zahlen sind gleich groß. Ihr Größter gemeinsamer Teiler ist {number1}");
            }
            else
            {
                while (number1 != number2)
                {
                    if (number1 > number2)
                    {
                        if (number1 - number2 > 0)
                        { 
                            number1 = number1 - number2; 
                        }
                    }
                    else
                    {
                        if (number2 - number1 > 0)
                        {
                            number2 = number2 - number1;
                        }
                    }
                }
            }
        }

        private static long PrimeNumberDecomposition(int number, out long primeNumber)
        {
  
            var primefactor = new StringBuilder();

            if (number == 1)
            {
                Console.WriteLine("Die Zahl ist nicht mehr teilbar, da sie bereits 1 ist.");
            }
            else
            {
                while (number % 2 == 0) // can be divided without residual value
                {
                    number = number / 2;
                    primefactor.Append(2);
                }
                for (int i = 3; i <= number; i = i + 2)
                    while (number % i == 0)  // while number can be divided without residual value
                    {
                        number = number / i;
                        primefactor.Append(i);
                    }
            }

            primeNumber = long.Parse(primefactor.ToString());
            return number;
            
        }
    }
}
