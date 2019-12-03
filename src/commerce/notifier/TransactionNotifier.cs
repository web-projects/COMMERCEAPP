using System;
using System.Collections.Generic;
using System.Text;
using WPA.CommerceApp.Helpers;
using WPA.CommerceApp.Interfaces;

namespace WPA.CommerceApp.Notifier
{
    public class TransactionNotifier : ITransactionNotifier
    {
        public void SendReceipt(OrderInfo orderInfo)
        {
            //                  0123456789012345678:
            Console.WriteLine($"notifier ----------: receipt sent to customer {orderInfo.CustomerName} via email.");
        }
    }
}
