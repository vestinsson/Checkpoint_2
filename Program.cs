using Checkpoint_2;

List<Product> products = new List<Product>();

while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("To enter a new product - follow the steps | To quit - enter \"Q\" to quit");
    Console.ResetColor();

    Console.Write("Enter a Category: ");
    string prod = Console.ReadLine();

    if (prod.ToUpper() == "Q")
    {
        break; // Exit the outer loop to quit the program
    }

    Console.Write("Enter a Product Name: ");
    string name = Console.ReadLine();

    int price;
    while (true)
    {
        Console.Write("Enter a Price: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out price))
        {
            break; // Valid input, exit the loop
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid price. Please enter a valid integer.");
            Console.ResetColor();
        }
    }

    Product p = new Product();
    p.Category = prod;
    p.ProductName = name;
    p.Price = price;
    products.Add(p);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The product was successfully added!");
    Console.ResetColor();
    //Console.WriteLine("To enter a new product - follow the steps | To qui");
    Console.WriteLine("--------------------------------------------------");
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Category".PadRight(15) + " " + "Product".PadRight(15) + " " + "Price");
Console.ResetColor();
List<Product> sortedProducts = products.OrderBy(p => p.Price).ToList();

foreach (Product p in sortedProducts) {
    Console.WriteLine(p.Category.PadRight(15) + " " + p.ProductName.PadRight(15) + " " + p.Price);
}
// List<Car> sortedCars = cars.OrderBy(car => car.Brand).ToList();
Console.WriteLine();
Console.WriteLine(" ".PadRight(16) + "Total amount:".PadRight(16) + products.Sum(p => p.Price));
Console.WriteLine("--------------------------------------------------");
Console.ForegroundColor= ConsoleColor.Blue;
Console.WriteLine("To enter a new product - enter: \"P\" | To search for a product - enter \"S\" | To quit - enter: \"Q\" ");
Console.ResetColor();

Console.WriteLine("branch 1 created");
