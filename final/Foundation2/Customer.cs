using System.Net.Sockets;

public class Customer
{
    private string _namePerson;
    Address address = new Address("139 West South 4th", "Rexburg", "ID", "USA");
    
    public Customer(string namePerson)
    {
        _namePerson = namePerson;
    } 
    public string GetName()
    {
        return _namePerson;
    }
    public void DisplayName()
    {
        System.Console.WriteLine($"Customer Name: {_namePerson}");
    }
}