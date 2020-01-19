using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGV
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

            long result = CalculateKGV(ref number1, ref number2);

            Console.WriteLine("Der KGV der beiden Zahlen beträgt " + result);
            Console.ReadKey();

        }

        private static long CalculateKGV(ref int number1, ref int number2)
        {
            int big;
            if (number1 == number2)
            { 
                return number1; 
            }
            else if (number1 > number2)
            {
                big = number1;
            }
            else
            {
                big = number2;
            }
            for (int i = big; i < number1 * number2; i++)
            {
                if (i % number1 == 0 && i % number2 == 0)
                { 
                    return i; 
                }
            }
            return number1 * number2;
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
