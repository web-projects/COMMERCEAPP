using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Reflection;
using WPA.CommerceApp.core;
using WPA.CommerceApp.factory;
using WPA.CommerceApp.Helpers;
using WPA.CommerceApp.Interfaces;
using WPA.CommerceApp.Notifier;

namespace WPA.CommerceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderInfo orderInfo = new OrderInfo()
            {
                CustomerName = "Jonnie Ringo",
                CreditCard = "1111 2222 3333 4444",
                EmailAddress = "jonnie.ringo@att.net",
                PhoneNumber = "555 333-4444",
                Product = "Boots",
                Price = 12.50
            };

            Commerce2(orderInfo);
        }

        static void Commerce1(OrderInfo orderInfo)
        {
            Commerce commerce = new Commerce(new BillingProcess(), new Customer(), new TransactionNotifier(), new Logger());
            commerce.ProcessOrder(orderInfo);
        }

        [Inject]
        static void Commerce2(OrderInfo orderInfo)
        {
            try
            {
                Ninject.IKernel kernel = new StandardKernel(new DI());
                var _OrderInfo = kernel.Get<OrderInfo>();
                var _BillingProcess = kernel.Get<BillingProcess>();
                var _Customer = kernel.Get<Customer>();
                var _TransactionNotifier = kernel.Get<TransactionNotifier>();
                var _Logger = kernel.Get<Logger>();

                Commerce commerce = new Commerce(_BillingProcess, _Customer, _TransactionNotifier, _Logger);
                commerce.ProcessOrder(orderInfo);
            }
            catch(Exception e)
            {
                Console.WriteLine($"main: exception=[{e.Message}]");
            }
        }


    }

    public class DI : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderInfo>().To<OrderInfo>().WithConstructorArgument("CustomerName", "Jonnie Ringo")
                                              .WithConstructorArgument("CreditCard", "1111 2222 3333 4444")
                                              .WithConstructorArgument("EmailAddress", "jonnie.ringo@att.net")
                                              .WithConstructorArgument("PhoneNumber", "555 333-4444")
                                              .WithConstructorArgument("Product", "Boots")
                                              .WithConstructorArgument("Price", 12.50);

            Bind<IBillingProcess>().To<BillingProcess>();
            Bind<ICustomer>().To<Customer>();
            Bind<ITransactionNotifier>().To<TransactionNotifier>();
            Bind<ILogger>().To<Logger>();
        }
    }
}
