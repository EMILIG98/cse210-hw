using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Main St", "Miami", "FL", "USA");
        Customer c1 = new Customer("John Smith", a1);

        Order order1 = new Order(c1);
        order1.AddProduct(new Product("Laptop", "LP100", 900, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 20, 2));

        
        Address a2 = new Address("Avenida Central", "Quito", "Pichincha", "Ecuador");
        Customer c2 = new Customer("Emilio Garcia", a2);

        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Phone", "PH500", 400, 1));
        order2.AddProduct(new Product("Charger", "CH100", 15, 3));

       
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order2.GetTotalPrice()}\n");
    }
}
    
