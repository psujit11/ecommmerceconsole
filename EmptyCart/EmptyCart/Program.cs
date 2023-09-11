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
            return $"{Name} - Price: {Price:C} - Description: {Description} - Stock: {StockQuantity}";
        }
    }

    static List<Product> cart = new List<Product>
    {
        new Product
        {
            Name = "Sujit_Ramen_24124",
            Price = 5.99m,
            Description = "Delicious Japanese ramen noodles.",
            StockQuantity = 10
        },
        new Product
        {
            Name = "Sujit_Panipuri_24124",
            Price = 3.49m,
            Description = "Indian street food delight - crispy and tangy.",
            StockQuantity = 20
        },
        new Product
        {
            Name = "Sujit_Chowmin_24124",
            Price = 6.99m,
            Description = "Chinese-style stir-fried noodles with vegetables.",
            StockQuantity = 15
        },
        new Product
        {
            Name = "Sujit_Momo_24124",
            Price = 4.99m,
            Description = "Tibetan dumplings with flavorful fillings.",
            StockQuantity = 12
        }
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("E-commerce Store Cart Menu:");
            Console.WriteLine("1. Display Cart");
            Console.WriteLine("2. Empty Cart");
            Console.WriteLine("3. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayCart();
                    break;
                case "2":
                    EmptyCart();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayCart()
    {
        Console.WriteLine("Cart Contents:");
        if (cart.Count == 0)
        {
            Console.WriteLine("The cart is empty.");
        }
        else
        {
            foreach (var product in cart)
            {
                Console.WriteLine(product);
            }
        }
    }

    static void EmptyCart()
    {
        cart.Clear();
        Console.WriteLine("Cart is now empty.");
    }
}
