using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_2
{
    internal class Product // product class with three Properties
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product() // default constructor, not used in this application
        {
        }
        public Product(string category, string productName,  double price) // constructor
        {
            Category = category;
            ProductName = productName;
            Price = price;
        }
    }
}
