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
        private Inventories productManager = new Inventories(); // productManager encapsulated in this class

        public void Start()
        {
            /*** special case when program start ***/
            productManager.AddProduct();
            productManager.DisplayProducts();
            /*** end special case ***/

            while (true) // running menu
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("To enter a new product - enter: \"P\" | To search for a product - enter \"S\" | To quit - enter: \"Q\" ");
                Console.ResetColor();

                string choice = Console.ReadLine().ToUpper();
                if (choice == "Q") 
                { 
                    break; 
                }
                else if (choice == "S")
                {
                    productManager.SeachProduct();
                }
                else if (choice == "P")
                {
                    productManager.AddProduct();
                    productManager.DisplayProducts();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Invalid Choice!");
                    Console.ResetColor();
                }

            } // end menu
        }
    }

}
