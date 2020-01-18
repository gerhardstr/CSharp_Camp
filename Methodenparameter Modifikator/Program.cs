using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodenparameter_Modifikator
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodenParameter();
        }

        static void MethodenParameter()
        {
            int dividend  = 123;
            int divisor = 32;
            int result;
            int rest;

            

            result = MethodeDivision(dividend, divisor, out rest); 

            Console.WriteLine($"Das Ergebnis lautet {result} und der Restwert ist {rest}.");
            Console.ReadKey();

            Console.WriteLine("Geben sie den Text ein:\n");
            string text = Console.ReadLine(); // "Die einzige Konstante ist die Veränderung";
            string textOld = text;

            MethodeString(ref text);
            Console.WriteLine($"{textOld} wurde geändert in {text}");
            Console.ReadKey();

        }

        public static int MethodeDivision(int dividend, int divisor, out int rest)
        {
            int result = dividend / divisor; 
            rest = dividend % divisor; 
            return result;
            
        }

        public static void MethodeString(ref string text)
        {
            text = text.Replace("ä", "ae").Replace("ö", "oe").Replace("ü", "ue").Replace("Ä", "Ae").Replace("Ö", "Ee").Replace("Ü", "ue").Replace("ß", "ss");
        }
    }
}
