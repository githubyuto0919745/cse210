using System;

class Program
{
    static void Main(string[] args)
    {
        List<float>total = new List<float>();
        Order order = new Order();
        Address address1 = new Address("139 West South 4th", "Rexburg", "ID", "USA");
        Address address2 = new Address("Seyaku Hongo 3-41-26", "Yokohama city", "Kanagawa", "Japan");
        Product product1 = new Product("Eggs", 1,4,3);
        Product product2 = new Product("Milk",3,3,2);
        Product product3 = new Product("Bread",4,2,3);
        Product product4 = new Product("Pork",5,15,2);

        Customer customer = new Customer("Yuto Akatsuka");
        Customer customer1 = new Customer("Joshua Harris");
        customer.DisplayName();
        Console.WriteLine("-------------------------------------------");
        order.productAmount(product1);
        order.productAmount(product2);
        order.productAmount(product3);
        order.DisplayProduct();
        order.Listprice(product1.Price());
        order.Listprice(product2.Price());
        order.Listprice(product3.Price());
        Console.WriteLine();
        order.GetCountry(address1.ReturnCountry());
        order.Total();
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel(customer.GetName(),product1.getID()));
        Console.WriteLine(order.PackingLabel(customer.GetName(),product2.getID()));
        Console.WriteLine(order.PackingLabel(customer.GetName(),product3.getID()));
        Console.WriteLine();
        Console.WriteLine(order.ShippingLabel(customer.GetName(), address1));
        Console.WriteLine("-------------------------------------------");
        Order order1 = new Order();
        Console.WriteLine();
        customer1.DisplayName();
        Console.WriteLine("-------------------------------------------");
        order1.productAmount(product3);
        order1.productAmount(product4);
        order1.DisplayProduct();
        order1.Listprice(product3.Price());
        order1.Listprice(product4.Price());
        Console.WriteLine();
        order1.GetCountry(address2.ReturnCountry());
        order1.Total();
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel(customer1.GetName(),product3.getID()));
        Console.WriteLine(order1.PackingLabel(customer1.GetName(),product4.getID()));
        Console.WriteLine();
        Console.WriteLine(order1.ShippingLabel(customer1.GetName(), address2));
        Console.WriteLine("-------------------------------------------");
    }
}