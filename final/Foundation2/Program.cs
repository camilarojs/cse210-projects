using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Wireless Mouse", "M100", 25.50, 2);
        Product product2 = new Product("Mechanical Keyboard", "K200", 75.00, 1);
        
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order1.CalculateTotalCost():F2}\n");
        Console.WriteLine("==================================================\n");

        Address address2 = new Address("456 Maple Road", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("USB-C Charging Cable", "C50", 12.99, 3);
        Product product4 = new Product("Laptop Stand", "S300", 45.00, 1);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order2.CalculateTotalCost():F2}\n");
    }
}