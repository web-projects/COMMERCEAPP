using Ninject;
using System;
using WPA.CommerceApp.Interfaces;

namespace WPA.CommerceApp.core
{
    public class BillingProcess : IBillingProcess
    {
        public void ProcessPayment(string customer, string creditCard, double price)
        {
            //                  0123456789012345678:
            Console.WriteLine($"billing -----------: payment process for customer {customer} on credit card {creditCard} for amount {price}.");
        }
    }
}