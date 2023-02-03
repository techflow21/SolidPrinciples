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


