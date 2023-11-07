
using System;

namespace ChainOfResponsibilityPattern
{
    // Handler interface
    public interface IPaymentHandler
    {
        void SetNext(IPaymentHandler handler);
        void Handle(double amount);
    }

    // Concrete handler 1
    public class BankPaymentHandler : IPaymentHandler
    {
        private IPaymentHandler _nextHandler;

        public void SetNext(IPaymentHandler handler)
        {
            _nextHandler = handler;
        }

        public void Handle(double amount)
        {
            if (amount < 1000)
            {
                Console.WriteLine($"Bank payment handler is processing the payment of {amount} dollars.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(amount);
            }
            else
            {
                Console.WriteLine("Payment cannot be processed.");
            }
        }
    }

    // Concrete handler 2
    public class PaypalPaymentHandler : IPaymentHandler
    {
        private IPaymentHandler _nextHandler;

        public void SetNext(IPaymentHandler handler)
        {
            _nextHandler = handler;
        }

        public void Handle(double amount)
        {
            if (amount >= 1000 && amount < 10000)
            {
                Console.WriteLine($"Paypal payment handler is processing the payment of {amount} dollars.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(amount);
            }
            else
            {
                Console.WriteLine("Payment cannot be processed.");
            }
        }
    }

    // Concrete handler 3
    public class BitcoinPaymentHandler : IPaymentHandler
    {
        private IPaymentHandler _nextHandler;

        public void SetNext(IPaymentHandler handler)
        {
            _nextHandler = handler;
        }

        public void Handle(double amount)
        {
            if (amount >= 100000)
            {
                Console.WriteLine($"Bitcoin payment handler is processing the payment of {amount} dollars.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(amount);
            }
            else
            {
                Console.WriteLine("Payment cannot be processed.");
            }
        }
    }


    // Client
    public class PaymentProcessor
    {
        private IPaymentHandler _handler;
        public PaymentProcessor(IPaymentHandler handler)
        {
            _handler = handler;
        }

        public void ProcessPayment(double amount)
        {
            _handler.Handle(amount);
        }
    }

    // Usage
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         var bankHandler = new BankPaymentHandler();
    //         var paypalHandler = new PaypalPaymentHandler();
    //         var bitcoinHandler = new BitcoinPaymentHandler();

    //         bankHandler.SetNext(paypalHandler);
    //         paypalHandler.SetNext(bitcoinHandler);


    //         var paymentProcessor = new PaymentProcessor(bankHandler);

    //         paymentProcessor.ProcessPayment(500); // Bank payment handler is processing the payment of 500 dollars.
    //         paymentProcessor.ProcessPayment(5000); // Paypal payment handler is processing the payment of 5000 dollars.
    //         paymentProcessor.ProcessPayment(50000); // Payment cannot be processed.

    //     }
    // }
}
