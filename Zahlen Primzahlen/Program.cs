using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenberechnungen
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("*                                                                           *");
                Console.WriteLine("*                 Welche Operation möchten sie durchführen?                 *");
                Console.WriteLine("*                                                                           *");
                Console.WriteLine("*****************************************************************************");

                Console.WriteLine("Bitte wählen Sie Operation aus:");
                Console.WriteLine("1: Primzahlenberechnung\n" +
                                  "2: Abundante und vollkommene Zahlen berechnen\n" +
                                  "3: Harshad-Zahl berrechnen\n" +
                                  "4: Beenden\n" +
                                  "Ihre Eingabe:");

                var userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Wieviele Zahlen wollen Sie analysieren? Bitte geben Sie eine Zahl ein:");
                        PrimeNumber numberPrime = new PrimeNumber(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Abudante und vollkommen Zahlen von 1 bis 1000");
                        AbudantNumber numberAbudant = new AbudantNumber();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Alle natürliche Zahlen von 1 bis 1000, die durch ihre eigene Quersumme teilbar sind (Harshad-Zahlen)");
                        HarshadNumber numberHarshad = new HarshadNumber();
                        break;
                    case ConsoleKey.D4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (true);            
        }
    }
}
