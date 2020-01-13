using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMaschine
{
    class Snack : Product
    {
        public string Type { get; set; }
        public Snack(string name, double price, string type) : base(name, price)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

    }
}
