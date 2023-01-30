namespace OpenCloseLibrary;

public class OpenCloseLogic
{
    public void OpenCloseDisplay()
    {
        Student student = new Student
        {
            Name = "Olaitan",
            Grade = "A"
        };
        student.PrintStudent();


        Console.WriteLine();


        SeniorStudent senior = new SeniorStudent
        {
            Name = "Emmanuel Joe",
            Grade = "D",
            GraduationYear = 2022
        };
        senior.PrintStudent();
    }

    public void OpenCloseDisplay2()
    {
        Order order = new Order(new CreditCardPayment());
        order.ProcessOrder();

        Console.WriteLine();

        order = new Order(new PayPalPayment());
        order.ProcessOrder();

    }
}


class Student
{
    public string Name { get; set; }
    public string Grade { get; set; }

    public virtual void PrintStudent()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Grade: {0}", Grade);
    }
}

class SeniorStudent : Student
{
    public int GraduationYear { get; set; }

    public override void PrintStudent()
    {
        base.PrintStudent();
        Console.WriteLine("Graduation Year: {0}", GraduationYear);
    }
}


//In this example, the Student class is open for extension(able to be inherited from) but closed for modification(the base class is not modified when new functionality is added). The SeniorStudent class inherits from the Student class and adds a new property and overrides the PrintStudent method to include the new property.

//In this example, the Order class is open for extension(new payment methods can be added without modifying the Order class) but closed for modification(the Order class does not need to be modified to handle new payment methods). The IPayment interface and the CreditCardPayment and PayPalPayment classes are used to demonstrate how new payment methods can be added to the system without modifying the Order class.

///// Another Implementation //////////

interface IPayment
{
    void ProcessPayment();
}

class CreditCardPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment with credit card.");
    }
}

class PayPalPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment with PayPal.");
    }
}

class Order
{
    private IPayment _payment;

    public Order(IPayment payment)
    {
        _payment = payment;
    }

    public void ProcessOrder()
    {
        _payment.ProcessPayment();
    }
}


