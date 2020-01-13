using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMaschine
{
    abstract class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }


    }
}
