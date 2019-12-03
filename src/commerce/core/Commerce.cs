using Ninject;
using System;
using WPA.CommerceApp.Helpers;
using WPA.CommerceApp.Interfaces;
using WPA.CommerceApp.Notifier;

namespace WPA.CommerceApp.core
{
    public class Commerce : ICommerce
    {
        private IBillingProcess _BillingProcessor;
        private ICustomer _Customer;
        private ITransactionNotifier _TransactionNotifier;
        private ILogger _Logger;

        public Commerce(IBillingProcess billingProcessor, ICustomer customer, ITransactionNotifier transactionNotifier, ILogger logger)
        {
            _BillingProcessor = billingProcessor;
            _Customer = customer;
            _TransactionNotifier = transactionNotifier;
            _Logger = logger;
        }

        public void ProcessOrder(OrderInfo orderInfo)
        {
            _BillingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.Price);
            _Logger.Log("billing processed");
            _Customer.UpdateCustomerOrder(orderInfo.CustomerName, orderInfo.Product);
            _Logger.Log("customer updated");
            _TransactionNotifier.SendReceipt(orderInfo);
            _Logger.Log("receipt sent");
        }
    }
}
