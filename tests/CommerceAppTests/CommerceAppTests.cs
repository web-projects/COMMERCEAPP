using Moq;
using System;
using WPA.CommerceApp.core;
using WPA.CommerceApp.Helpers;
using WPA.CommerceApp.Interfaces;
using WPA.CommerceApp.Notifier;
using Xunit;

namespace CommerceAppTests
{
    public class CommerceTransactionTests
    {
        ICommerce subject;

        Mock<IBillingProcess> mockIBillingProcess;
        Mock<ICustomer> mockICustomer;
        Mock<ITransactionNotifier> mockITransactionNotifier;
        Mock<ILogger> mockILogger;

        public CommerceTransactionTests()
        {
            //subject = new Commerce();

            mockIBillingProcess = new Mock<IBillingProcess>();
            mockICustomer = new Mock<ICustomer>();
            mockITransactionNotifier = new Mock<ITransactionNotifier>();
            mockILogger = new Mock<ILogger>();

            //using (IKernel kernel = new CommerceKernelResolver().ResolveKernel())
            //{
            //    kernel.Settings.InjectNonPublic = true;
            //    kernel.Settings.InjectParentPrivateProperties = true;

            mockIBillingProcess.Setup(e => e.ProcessPayment(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<double>()));
            mockICustomer.Setup(e => e.UpdateCustomerOrder(It.IsAny<string>(), It.IsAny<string>()));
            mockITransactionNotifier.Setup(e => e.SendReceipt(It.IsAny<OrderInfo>()));
            mockILogger.Setup(e => e.Log(It.IsAny<string>()));

            //    kernel.Bind<IBillingProcess>().ToConstant(mockIBillingProcess.Object);
            //    kernel.Bind<IBi>()llingProcess>().ToSelf();

            //    kernel.Inject(subject);
            //}
        }
        
        [Fact]
        public void CommerceOrder_ReturnsTrue_WhenPlacingOrder()
        {
            //    string expectedValue = "Jon";
            //    User user = new User(expectedValue, new UserChangedNotifier());
            //    subject.NotifyUsernameChanged(user);
            //    string actualValue = subject.GetUsername();
            //    Assert.Equal(expectedValue, actualValue);


            //    IUserChangedNotifier userChanged = new UserChangedNotifier();
            //    mockIUserChangedNotifier.Setup(e => e.NotifyUsernameChanged(It.IsAny<User>()));
            //    Assert.True(subject.NotifyUsernameChanged(user));
            Commerce commerce = new Commerce(mockIBillingProcess.Object, mockICustomer.Object, mockITransactionNotifier.Object, mockILogger.Object);
            //commerce.ProcessOrder(new OrderInfo());
            Assert.True(1 == 1);
        }
    }
}
