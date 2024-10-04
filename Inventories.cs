using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_2
{
    internal class Inventories
    {
        private List<Product> products = new List<Product>(); // products encapsulated in this class
        public void AddProduct()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("To enter a new product - follow the steps | To quit - enter \"Q\" to quit");
                Console.ResetColor();

                Console.Write("Enter a Category: ");
                string category = Console.ReadLine();
                if (category.ToUpper() == "Q") return; // quit input of new products

                Console.Write("Enter a Product Name: ");
                string name = Console.ReadLine();

                int price = GetValidPrice(); // check for integer input

                // creates a new prodoct
                Product p = new Product { Category = category, ProductName = name, Price = price };
                products.Add(p); // adds created product to the list

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The product was successfully added!");
                Console.ResetColor();
                Console.WriteLine("--------------------------------------------------");
            }
        }

        private int GetValidPrice() // the method is encapsulated in this class
        {
            while (true)
            {
                Console.Write("Enter a Price: ");
                if (int.TryParse(Console.ReadLine(), out int price)) // code snippet that check input
                {
                    return price;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid price. Please enter a valid integer.");
                Console.ResetColor();
            }
        }

        // overloaded Display(string s) method code repeats almost everything of DisplayProduct(),
        // THAT'S NO GOOD :(
        // perhaps I try to solve it with default parameter instead off overloading the metod???

        //public void DisplayProducts() // display ascending ordered list, sum up the prices
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Category".PadRight(15) + " " + "Product".PadRight(15) + " " + "Price");
        //    Console.ResetColor();

        //    // sortedProducts is local list variable 
        //    // using lambda expression a.k.a anonymous function: p => p.Price
        //    List<Product> sortedProducts = products.OrderBy(p => p.Price).ToList(); // local list variable
        //    foreach (Product p in sortedProducts) // iterate the list
        //    {
        //        Console.WriteLine(p.Category.PadRight(15) + " " + p.ProductName.PadRight(15) + " " + p.Price);
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine(" ".PadRight(16) + "Total amount:".PadRight(16) + products.Sum(p => p.Price));
        //    Console.WriteLine("--------------------------------------------------");
        //}

        public void DisplayProducts(string searchString = "") // takes string to search as parameter, if default empty no search/mark in list 
        { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Category".PadRight(15) + " " + "Product".PadRight(15) + " " + "Price");
            Console.ResetColor();

            // sortedProducts is local list variable 
            // using lambda expression a.k.a anonymous function: p => p.Price
            List<Product> sortedProducts = products.OrderBy(p => p.Price).ToList(); // local list variabel
            foreach (Product p in sortedProducts)
            {
                // if search string found color it purple
                if (p.ProductName.Contains(searchString, StringComparison.OrdinalIgnoreCase) && searchString != "")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                Console.WriteLine(p.Category.PadRight(15) + " " + p.ProductName.PadRight(15) + " " + p.Price);
                Console.ResetColor();
            }

            Console.WriteLine("--------------------------------------------------");
        }

        public void SeachProduct() // simple menu for input search term and call to overloaded DisplayProducts()
        {
            Console.Write("Enter a Product Name: ");
            string searchedProduct = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------");
            DisplayProducts(searchedProduct);
        }
    }
}
