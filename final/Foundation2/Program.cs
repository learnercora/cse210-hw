using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Program 2: Encapsulation with Online Ordering");

        // Create products
        Product product1 = new Product("Product1","P1",10,2);
        Product product2 = new Product("Product2","P2",15,3);
        Product product3 = new Product("Product3","P3",15,3);
        Product product4 = new Product("Product4","P4",15,3);

        // Create addresses
        Address address1 = new Address("123 Main St","City1","State1","USA");
        Address address2 = new Address("456 Elm St","City2","State2","Canada");

        // Create customers
        Customer customer1 = new Customer("Customer1",address1);
        Customer customer2 = new Customer("Customer2",address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // List<Order> orders = new List<Order> {order1,order2};

        // Display packing label, shipping label, and total cost for each order
        // foreach (Order order in orders)
        // {
        //     Console.WriteLine(order.GetPackingLabel());
        //     Console.WriteLine(order.GetShippingLabel());
        //     Console.WriteLine("Total Cost: $" + order.CalculateTotalCost());
        //     Console.WriteLine("=====================");
        // }
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
}