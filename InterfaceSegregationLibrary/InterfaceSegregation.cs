using System.Diagnostics;

namespace InterfaceSegregationLibrary;

//In this example, the IProduct interface defines the Name and Price properties that must be implemented by all subclasses.The IElectronic and IBook interfaces inherit from the IProduct interface and add the WarrantyMonths and Author properties, respectively. The Electronic and Book classes implement the IElectronic and IBook interfaces, respectively.The ShoppingCart class accepts an array of IProduct instances and calculates the total by summing the Price of each product.This demonstrates the Interface Segregation Principle because each interface is specific to a particular type of product, and classes only need to implement the properties and methods that are relevant to their type.
public class InterfaceSegregation
{
    public void InterfaceSegDisplay()
    {
        IProduct[] products = new IProduct[]
        {
            new Electronic { Name = "Laptop", Price = 1250.99M, WarrantyMonths = 24 },
            new Book { Name = "The Art of C# Programming", Price = 56.90M, Author = "NoName Author" }
        };

        ShoppingCart cart = new ShoppingCart(products);
        decimal total = cart.CalculateTotal();

        Console.WriteLine("Total: {0:C2}", total);
    }
}


public interface IProduct
{
    string Name { get; set; }
    decimal Price { get; set; }
}


public interface IElectronic : IProduct
{
    int WarrantyMonths { get; set; }
}


public interface IBook : IProduct
{
    string Author { get; set; }
}


public class Electronic : IElectronic
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int WarrantyMonths { get; set; }
}


public class Book : IBook
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Author { get; set; }
}


public class ShoppingCart
{
    private IProduct[] _products;

    public ShoppingCart(IProduct[] products)
    {
        _products = products;
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;

        foreach (IProduct product in _products)
        {
            total += product.Price;
        }

        return total;
    }
}
