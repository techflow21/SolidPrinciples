
namespace DependencyInversionLibrary;

public class DependencyInversion
{
    public void DependencyInversionDisplay()
    {
        IPayment payment = new CreditCard();

        ShoppingCart cart = new ShoppingCart(payment, 99.99M);
        cart.CheckOut();

    }
}


public interface IPayment
{
    void Pay(decimal amount);
}


public class CreditCard : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Paying {0:C2} using Credit Card.", amount);
    }
}


public class PayPal : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Paying {0:C2} using PayPal.", amount);
    }
}


public class ShoppingCart
{
    private IPayment _payment;
    private decimal _amount;

    public ShoppingCart(IPayment payment, decimal amount)
    {
        _payment = payment;
        _amount = amount;
    }

    public void CheckOut()
    {
        _payment.Pay(_amount);
    }
}

