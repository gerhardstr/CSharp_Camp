using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMaschine
{
    class Program
    {
        static void Main(string[] args)
        {
            getProductsAndStart(); 
        }

        private static void getProductsAndStart()
        {
            List<Product> products = new List<Product>(); // list of products

            products.Add(new Drink("Coca Cola", 3));
            products.Add(new Drink("Red Bull", 4));
            products.Add(new Drink("Combucha", 3.5));
            products.Add(new Drink("Pepsi", 3.5));
            products.Add(new Drink("Apfelsaft", 3.5));
            products.Add(new Drink("Bier", 5.5));

            products.Add(new Snack("Käsesemmel", 4, "snack"));
            products.Add(new Snack("Wurstsemmel", 5, "snack"));
            products.Add(new Snack("Butterbrot", 2, "snack"));
            products.Add(new Snack("Lion", 3, "candy"));
            products.Add(new Snack("Twix", 3, "candy"));
            products.Add(new Snack("Bounty", 3, "candy"));

            products.Add(new Fruit("Apfel", 1));
            products.Add(new Fruit("Orange", 2));
            products.Add(new Fruit("Banane", 2));
            products.Add(new Fruit("Ananas", 10));

            Maschine maschine = new Maschine(products);
            maschine.Start();
        }
    }
}
