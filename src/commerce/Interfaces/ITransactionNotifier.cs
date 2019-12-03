using WPA.CommerceApp.Helpers;

namespace WPA.CommerceApp.Notifier
{
    public interface ITransactionNotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}