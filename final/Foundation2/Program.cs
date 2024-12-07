using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("510 S Center St", "Rexburg", "Idaho", "USA");
        Address internationalAddress = new Address("14335 53 Ave NW", "Edmonton", "Alberta", "Canada");

        Customer customer1 = new Customer("Nicson White", usaAddress);
        Customer customer2 = new Customer("Tom Brady", internationalAddress);

        Product product1 = new Product("Laptop", "L525", 274.99m, 5);
        Product product2 = new Product("Monitor", "M234", 125.00m, 5);
        Product product3 = new Product("Printer", "P808", 79.90m, 2);
        Product product4 = new Product("Fax Machine", "F723", 54.78m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order #1: ");
        Console.WriteLine($"Total Cost: {order1.OrderCost()}");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine($"{order1.PackingLabel()}");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{order1.ShippingLabel()}");
        Console.WriteLine();

        Console.WriteLine("Order #2: ");
        Console.WriteLine($"Total Cost: {order2.OrderCost()}");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine($"{order2.PackingLabel()}");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{order2.ShippingLabel()}");
        Console.WriteLine();





    }
}