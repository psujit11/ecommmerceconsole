using System;
using System.Collections.Generic;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }

        public override string ToString()
        {
            return $"{Name} - Price: {Price} - Description: {Description} - Stock: {StockQuantity}";
        }
    }

    static List<Product> productList = new List<Product>
    {
        new Product
        {
            Name = "Sujit_Ramen_24124",
            Price = 59.9m,
            Description = "Delicious Japanese ramen noodles.",
            StockQuantity = 10
        },
        new Product
        {
            Name = "Sujit_Panipuri_24124",
            Price = 349m,
            Description = "Indian street food delight - crispy and tangy.",
            StockQuantity = 20
        },
        new Product
        {
            Name = "Sujit_Chowmin_24124",
            Price = 699m,
            Description = "Chinese-style stir-fried noodles with vegetables.",
            StockQuantity = 15
        },
        new Product
        {
            Name = "Sujit_Momo_24124",
            Price = 499m,
            Description = "Tibetan dumplings with flavorful fillings.",
            StockQuantity = 12
        }
    };

    static List<Product> wishList = new List<Product>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("E-commerce Store Menu:");
            Console.WriteLine("1. Display Product List");
            Console.WriteLine("2. Add Product to Wish List");
            Console.WriteLine("3. Display Wish List");
            Console.WriteLine("4. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayProductList();
                    break;
                case "2":
                    AddProductToWishList();
                    break;
                case "3":
                    DisplayWishList();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayProductList()
    {
        Console.WriteLine("Product List:");
        foreach (var product in productList)

        {
            Console.WriteLine(product);
        }
    }

    static void AddProductToWishList()
    {
        Console.Write("Enter the product name to add to the wish list: ");
        string proName = Console.ReadLine();
        string productName = $"Sujit_{proName}_24124";
        Product productToAdd = productList.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

        if (productToAdd != null)
        {
            wishList.Add(productToAdd);
            Console.WriteLine($"{productToAdd.Name} added to the wish list.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    static void DisplayWishList()
    {
        Console.WriteLine("Wish List:");
        if (wishList.Count == 0)
        {
            Console.WriteLine("The wish list is empty.");
        }
        else
        {
            foreach (var product in wishList)
            {
                Console.WriteLine(product);
            }
        }
    }
}

