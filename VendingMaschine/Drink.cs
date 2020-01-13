using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMaschine
{
    class Drink : Product
    {
        public Drink(string name, double price) : base(name, price)
        {
            this.Name = name;
            this.Price = price;
            
        }
    }
}
