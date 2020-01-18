using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bitte eine Zahl, eine Rechenoperation (+-*/) \n und eine weitere Zahl eingeben (Beispiel:5+5):");
            string operation = Console.ReadLine();

            GetOperationAndNumbers(out int number1, out int number2, operation, out string operatorSign);

            switch (operatorSign)
            {
                case "+":
                    Addition(number1, number2, out int summe);
                    Console.WriteLine($"Die Summe von {number1} und {number2} lautet: {summe}");
                    Console.ReadKey();
                    break;
                case "-":
                    Subtraktion(number1, number2, out int differenz);
                    Console.WriteLine($"Die Differenz von {number1} und {number2} lautet: {differenz}");
                    Console.ReadKey();
                    break;
                case "*":
                    Multiplikation(number1, number2, out int multiplikation);
                    Console.WriteLine($"Die Multiplikation von {number1} und {number2} ergibt {multiplikation}");
                    Console.ReadKey();
                    break;
                case "/":
                    Division(number1, number2, out int result, out int rest);
                    Console.WriteLine($"{number1} / {number2} = {result} mit einem Rest von {rest}");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Rechenzeichen oder Zahl nicht richtig eingegeben!");
                    break;
            }

            Console.ReadKey();
        }

        private static void GetOperationAndNumbers(out int number1, out int number2, string operation, out string operatorSign)
        {
            string calculation = "+-/*"; // all operations
            char[] anyOf = calculation.ToCharArray(); // to array
            int position = operation.LastIndexOfAny(anyOf); // zero-based index of operation sign
            number1 = Convert.ToInt32(operation.Substring(0, position));
            number2 = Convert.ToInt32(operation.Substring(position+1, operation.Length - position - 1));
            operatorSign = operation.Substring(position, 1);
        }

        private static void Addition(int summand1, int summand2, out int summe)
        {
            summe = summand1 + summand2;
        }

        private static void Subtraktion(int minuend, int subtrahend, out int differenz)
        {
            differenz = minuend - subtrahend;
        }

        private static void Multiplikation(int multiplikator, int multiplikand, out int multiplikation)
        {
            multiplikation = multiplikator * multiplikand;
        }

        private static void Division(int dividend, int divisor, out int result, out int rest)
        {
            result = dividend / divisor;
            rest =  divisor % dividend;
        }
    }
}
