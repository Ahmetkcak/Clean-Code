
using System;

// Strategy interface
public interface IPaymentStrategy
{
    void Pay(double amount);
}

// Concrete strategy classes
public class CreditCardPaymentStrategy : IPaymentStrategy
{
    private string _name;
    private string _cardNumber;
    private string _cvv;
    private string _expiryDate;

    public CreditCardPaymentStrategy(string name, string cardNumber, string cvv, string expiryDate)
    {
        _name = name;
        _cardNumber = cardNumber;
        _cvv = cvv;
        _expiryDate = expiryDate;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} TL with credit card.");
    }
}

public class PayPalPaymentStrategy : IPaymentStrategy
{
    private string _email;
    private string _password;

    public PayPalPaymentStrategy(string email, string password)
    {
        _email = email;
        _password = password;
    }

    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} TL with PayPal.");
    }
}

// Context class
public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Pay(double amount)
    {
        _paymentStrategy.Pay(amount);
    }
}

// Client code
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Credit card payment
//         var creditCardPayment = new PaymentContext(new CreditCardPaymentStrategy("John Doe", "1234567890123456", "123", "12/23"));
//         creditCardPayment.Pay(100.0);

//         // PayPal payment
//         var payPalPayment = new PaymentContext(new PayPalPaymentStrategy("johndoe@example.com", "password123"));
//         payPalPayment.Pay(50.0);
//     }
// }
