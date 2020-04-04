using System;
using System.Collections.Generic;
using System.Text;

namespace Example2ConsoleApp1.Handlers
{
    public class NetBankingCardHandler:BaseHandler
    {
        public override void Process(Request request)
        {
            if(request.Data is PaymentMethod paymentMethod)
            {
                if (paymentMethod.PaymentType == PaymentType.NetBanking)
                    Console.WriteLine("Net Banking Processing");
                else if (_nextHandler != null)
                    _nextHandler.Process(request);
                else
                    Console.WriteLine("Invalid Handler");
            }
        }
    }
}
