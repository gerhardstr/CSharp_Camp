using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMaschine
{
    class Maschine
    {
        int id = 0;
        public List<Product> products { get; set; }

        public Maschine(List<Product> products)
        {
            this.products = products;
        }

        public void Start()
        {
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*                  Herzlich willkommen beim Rai-Imbiss                      *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Bitte wählen Sie Produkt aus:");
            Console.WriteLine("1: Getränke\n" +
                              "2: Snack\n" +
                              "3: Frucht\n" +
                              "4: Beenden\n" +
                              "Ihre Eingabe:");

            var Input = Console.ReadKey();

            List<Product> userSelection = new List<Product>();
            Console.Clear();

            switch (Input.Key)
            {
                case ConsoleKey.D1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Sie haben Getränke gewählt. Welches Getränk darf es sein?\n");
                    Console.ResetColor();

                    foreach (var item in products)
                    {
                        if (item is Drink)
                        {
                            Console.WriteLine(Convert.ToString(id) + ": " + item.Name);
                            userSelection.Add(item);
                        }
                        id = id++;
                    }

                    AddList(userSelection);
                    Console.ReadKey();
                    break;

                case ConsoleKey.D2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Sie haben Snacks gewählt. Welcher Snack darf es sein?\n");
                    Console.ResetColor();

                    foreach (var item in products)
                    {
                        if (item is Snack)
                        {
                            Console.WriteLine(Convert.ToString(id) + ": " + item.Name);
                            userSelection.Add(item);
                        }
                        id = id++;
                    }

                    AddList(userSelection);
                    Console.ReadKey();
                    break;
                case ConsoleKey.D3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Sie haben Frucht gewählt. Welche Frucht darf es sein?\n");
                    Console.ResetColor();

                    foreach (var item in products)
                    {
                        if (item is Fruit)
                        {
                            Console.WriteLine(Convert.ToString(id) + ": " + item.Name);
                            userSelection.Add(item);
                        }
                        id = id++;
                    }

                    AddList(userSelection);
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
        void AddList(List<Product> userSelected)
        {           
            foreach (Product item in userSelected)
            {
                AddUp(item);
                break;
            }
        }

        public void AddUp(Product product)
        {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Sie haben {product.Name} für {product.Price} Euro ausgewählt.");
                Console.ResetColor();
                Console.ReadKey();    
        }
    }
}
