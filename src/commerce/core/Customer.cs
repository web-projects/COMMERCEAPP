using System;
using WPA.CommerceApp.Interfaces;

namespace WPA.CommerceApp.core
{
    public class Customer : ICustomer
    {
        public void UpdateCustomerOrder(string customer, string product)
        {
            //                  0123456789012345678:
            Console.WriteLine($"customer ----------: record for '{customer}' updated with purchase of product '{product}'.");
        }
    }
}