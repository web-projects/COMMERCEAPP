using System;
using System.Collections.Generic;
using System.Text;
using WPA.CommerceApp.Interfaces;

namespace WPA.CommerceApp.Helpers
{
    public class OrderInfo : IOrderInfo
    {
        public string CustomerName { get; set; }
        public string CreditCard { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }

        public OrderInfo()
        {

        }

        public OrderInfo(string customerName, string creditCard, string emailAddress, string phoneNumber, string product, double price) => (CustomerName, CreditCard, EmailAddress, PhoneNumber, Product, Price) =
            (CustomerName = customerName, CreditCard = creditCard, EmailAddress = emailAddress, PhoneNumber = phoneNumber, Product = product, Price = price);
    }
}
