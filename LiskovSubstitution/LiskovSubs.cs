
using System.Diagnostics;

namespace LiskovSubstitution;

public class LiskovSubs
{
    public void LiskovSubsDisplay()
    {
        Student[] students = new Student[]
        {
            new UndergradStudent { Name = "Johnson Ade", Grade = "A", Credits = 120 },
            new GradStudent { Name = "Janet Boi", Grade = "B", ResearchArea = "AI" }
        };

        foreach (Student student in students)
        {
            Console.WriteLine($" Name: {student.Name}\n GPA: {student.CalculateGPA()}\n");
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        IProduct[] products = new IProduct[]
        {
            new Book { Name = "Learn C# in One Day", Price = 19.99M },
            new Electronic { Name = "Smartphone", Price = 499.99M }
        };

        ShoppingCart cart = new ShoppingCart(products);
        decimal total = cart.CalculateTotal();

        Console.WriteLine("Total: {0:C2}", total);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

abstract class Student
{
    public string Name { get; set; }
    public string Grade { get; set; }

    public abstract int CalculateGPA();
}


class UndergradStudent : Student
{
    public int Credits { get; set; }

    public override int CalculateGPA()
    {
        return (Grade == "A") ? 4 : 3;
    }
}


class GradStudent : Student
{
    public string ResearchArea { get; set; }

    public override int CalculateGPA()
    {
        return (Grade == "A") ? 4 : 3;
    }
}


interface IProduct
{
    string Name { get; set; }
    decimal Price { get; set; }
    decimal CalculateTax();
}


class Book : IProduct
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal CalculateTax()
    {
        return Price * 0.05M;
    }
}


class Electronic : IProduct
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal CalculateTax()
    {
        return Price * 0.10M;
    }
}


class ShoppingCart
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
            total += product.Price + product.CalculateTax();
        }
        return total;
    }
}


