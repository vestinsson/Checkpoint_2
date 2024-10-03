using Checkpoint_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_2
{
    internal class Screen
    {
        private Inventories productManager = new Inventories();

        public void Start()
        {
            while (true)
            {
                productManager.AddProduct();
                productManager.DisplayProducts();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("To enter a new product - enter: \"P\" | To search for a product - enter \"S\" | To quit - enter: \"Q\" ");
                Console.ResetColor();
                Console.WriteLine("*******************************************");

                string choice = Console.ReadLine().ToUpper();
                if (choice == "Q") break;
                if (choice == "S")
                {
                    productManager.index = productManager.SeachProduct();
                    Console.WriteLine(productManager.index); // för felsökning
                }
            }
        }
    }

}
