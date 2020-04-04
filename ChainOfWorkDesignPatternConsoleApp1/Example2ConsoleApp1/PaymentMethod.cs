using System;
using System.Collections.Generic;
using System.Text;

namespace Example2ConsoleApp1
{
    public enum PaymentType
    {
        CreditCard=1,
        DebitCard=2,
        NetBanking=3
    }

    public class PaymentMethod
    {
        public PaymentType PaymentType { get; set; }
    }
}
