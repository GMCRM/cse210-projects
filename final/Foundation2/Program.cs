using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product laptop = new Product("Laptop", "P001", 1000.00m, 1);
        Product smartphone = new Product("Smartphone", "P002", 600.00m, 2);
        Product tablet = new Product("Tablet", "P003", 300.00m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(laptop);
        order1.AddProduct(smartphone);

        Order order2 = new Order(customer2);
        order2.AddProduct(smartphone);
        order2.AddProduct(tablet);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}");
    }
}