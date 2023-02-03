
namespace SingleResponsibilityLibrary;

public class SingleResponsibilityLogic
{
    public void Display()
    {
        Customer customer = new Customer
        {
            Name = "SOB Techs",
            Address = "123 King St.",
            PhoneNumber = "111-555-5555"
        };
        customer.DisplayCustomerInfo();

        Order order = new Order
        {
            OrderNumber = 1,
            ProductName = "Computer",
            Quantity = 6,
            Price = 1680.00
        };
        order.DisplayOrderInfo();
    }
}


// Class for handling customer information
public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }


    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"\n\t Name: {Name}\n\t Address: {Address}\n\t Phone Number: {PhoneNumber}\n");
    }
}


// Class for handling customer orders
public class Order
{
    public int OrderNumber { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }


    public void DisplayOrderInfo()
    {
        Console.WriteLine($"\n\t Order Number: {OrderNumber}\n\t Product Name: {ProductName}\n\t Quantity: {Quantity}\n\t Price: ${Price}\n");
    }
}



// In the above code, the Customer class is responsible for handling customer information, and the Order class is responsible for handling customer orders. Each class has a single responsibility and does not handle tasks that are not related to its specific purpose. This follows the Single Responsibility Principle and makes the code easier to maintain and understand.