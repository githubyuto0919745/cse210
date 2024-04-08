using System.Runtime.CompilerServices;

public class Product
{
    private  string _nameProduct;
    private  int _id;
    private  int _price;
    private  int _quantity;
    private  float _total;

    public Product()
    {
        
    }
    public Product(string nameProduct, int id, int price, int quantity)
    {
        _nameProduct = nameProduct;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public int getID()
    {
        return _id;
    }
    public float Price()
    {
        _total = _price * _quantity;
        return _total;
    }
    public string NameProduct 
    { 
        get { return _nameProduct; } 
        set { _nameProduct = value; } 
    }

    public int ID 
    { 
        get { return _id; } 
        set { _id = value; } 
    }

    public int Prices 
    { 
        get { return _price; } 
        set { _price = value; } 
    }

    public int Quantity 
    { 
        get { return _quantity; } 
        set { _quantity = value; } 
    }
}