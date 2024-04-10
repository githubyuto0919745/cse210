using System.Data.Common;
using System.Net.Http.Headers;

public class Order
{
    List<Product>products = new List<Product>(); 
    Product pro = new Product();
    private List<float> order = new List<float>();
    Address address = new Address();
    Product product = new Product();

    public void productAmount(Product product)
    {
        products.Add(product);
    }
    public void DisplayProduct()
    {
        foreach(Product product in products)
        {
            System.Console.WriteLine($"Product name: {product.NameProduct} \n Quantity: {product.Quantity} \n Price: ${product.Prices}");

        }
    }
    public void Listprice(float _total)
    {
        order.Add(_total);
    }
    public void Total()
    {
        System.Console.WriteLine($"Total price after shipping fee: ${order.Sum()}");

    }

    public void GetCountry(string _country)
    {
        if (_country.ToUpper() == "USA")
        {

         Console.WriteLine("Shipping fee within the USA is $5");
            order.Add(5);
        }
        else
        {
            Console.WriteLine("Shipping fee outside of the USA is $35");
            order.Add(35);
        }
    }    
    public string PackingLabel(string _name, int _id)
    {
        return $"Name: {_name}, product ID: {_id}";
    }
    public string ShippingLabel(string _name, Address address)
    {
        return $"Shipping Label:\nName: {_name}\nAddress: {address.Addresses},\n{address.City}, {address.State}, {address.Country}";
    }
        

}