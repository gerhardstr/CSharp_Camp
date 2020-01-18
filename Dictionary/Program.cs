using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomDictonary();
        }

        private static void RandomDictonary()
        {
            int end = 5000;
            Random randomNumberGenerator = new Random();

            Dictionary<int, string> dictonary = new Dictionary<int, string>();

            int cnt = 0;
            for (int i = 0; i < end; i++)
            {
                try
                {
                    int randomNumber = randomNumberGenerator.Next(0, 20000);
                    dictonary.Add(randomNumber, RandomString(8));
                    Console.WriteLine($"{cnt}. Eintrag im Dictonary: {dictonary[randomNumber]}");
                }
                catch (Exception)
                {
                    int newRandomNumber = 0;
                    while (dictonary.ContainsKey(newRandomNumber))
                    {
                        newRandomNumber = randomNumberGenerator.Next(0, 20000);
                    }

                    dictonary.Add(newRandomNumber, RandomString(8));
                    Console.WriteLine($"Fehlerbehandlung! > {cnt}. Eintrag im Dictonary: {dictonary[newRandomNumber]}");
                }
                cnt++;
            }
            Console.ReadKey();
        }
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
