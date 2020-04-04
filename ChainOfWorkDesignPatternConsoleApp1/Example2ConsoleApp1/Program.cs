using Example2ConsoleApp1.Handlers;
using System;

namespace Example2ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example-2 !");

            PaymentMethod paymentMethod = new PaymentMethod() { PaymentType = PaymentType.CreditCard };
            Request request = new Request() { Data= paymentMethod };

            CreditCardHandler creditCardHandler = new CreditCardHandler();
            DebitCardHandler debitCardHandler = new DebitCardHandler();
            NetBankingCardHandler netBankingCardHandler = new NetBankingCardHandler();

            creditCardHandler.SetNextHandler(debitCardHandler);
            debitCardHandler.SetNextHandler(netBankingCardHandler);

            creditCardHandler.Process(request);

            Console.ReadLine();

        }
    }
}
