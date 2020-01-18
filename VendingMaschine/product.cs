using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMaschine
{
    abstract class Product
    {
        public double IdentNr { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public int Piece { get; set; }
        public string Description { get; set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        


    }
}
