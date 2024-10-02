using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_2
{
    internal class Product
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string category, string productName,  double price)
        {
            Category = category;
            ProductName = productName;
            Price = price;
        }

    }
}
