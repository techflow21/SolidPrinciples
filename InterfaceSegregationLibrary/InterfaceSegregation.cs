using System.Diagnostics;
namespace InterfaceSegregationLibrary;

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
