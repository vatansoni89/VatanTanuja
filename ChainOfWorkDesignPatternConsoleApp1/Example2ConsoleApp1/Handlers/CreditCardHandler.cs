using System;
using System.Collections.Generic;
using System.Text;

namespace Example2ConsoleApp1.Handlers
{
    public class CreditCardHandler:BaseHandler
    {
        public override void Process(Request request)
        {
            if(request.Data is PaymentMethod paymentMethod)
            {
                if (paymentMethod.PaymentType == PaymentType.CreditCard)
                    Console.WriteLine("Credit Card Processing");
                else if (_nextHandler != null)
                    _nextHandler.Process(request);
                else
                    Console.WriteLine("Invalid Handler");
            }
        }
    }
}
