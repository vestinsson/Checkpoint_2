using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_2
{
    internal class Inventories
    {
        private List<Product> products = new List<Product>();
        public void AddProduct()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("To enter a new product - follow the steps | To quit - enter \"Q\" to quit");
                Console.ResetColor();

                Console.Write("Enter a Category: ");
                string category = Console.ReadLine();
                if (category.ToUpper() == "Q") return;

                Console.Write("Enter a Product Name: ");
                string name = Console.ReadLine();

                int price = GetValidPrice();

                Product p = new Product { Category = category, ProductName = name, Price = price };
                products.Add(p);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The product was successfully added!");
                Console.ResetColor();
                Console.WriteLine("--------------------------------------------------");
            }
        }

        private int GetValidPrice()
        {
            while (true)
            {
                Console.Write("Enter a Price: ");
                if (int.TryParse(Console.ReadLine(), out int price))
                {
                    return price;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid price. Please enter a valid integer.");
                Console.ResetColor();
            }
        }

        public void DisplayProducts()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Category".PadRight(15) + " " + "Product".PadRight(15) + " " + "Price");
            Console.ResetColor();

            List<Product> sortedProducts = products.OrderBy(p => p.Price).ToList();
            foreach (Product p in sortedProducts)
            {
                Console.WriteLine(p.Category.PadRight(15) + " " + p.ProductName.PadRight(15) + " " + p.Price);
            }

            Console.WriteLine();
            Console.WriteLine(" ".PadRight(16) + "Total amount:".PadRight(16) + products.Sum(p => p.Price));
            Console.WriteLine("--------------------------------------------------");
        }

        public void SeachProduct()
        {
            Console.Write("Enter a Product Name: ");
            string searchedProduct = Console.ReadLine();

            var matchingProducts = products.Where(p => p.ProductName.Contains(searchedProduct, StringComparison.OrdinalIgnoreCase)); // .ToList()

            if (matchingProducts.Any())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Category".PadRight(15) + " " + "Product".PadRight(15) + " " + "Price");
                Console.ResetColor();

                foreach (var p in matchingProducts)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(p.Category.PadRight(15) + " " + p.ProductName.PadRight(15) + " " + p.Price);
                }
                Console.ResetColor();
                //DisplayProducts();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("To enter a new product - enter: \"P\" | To search for a product - enter \"S\" | To quit - enter: \"Q\" ");
            Console.ResetColor();

        }
    }
}
