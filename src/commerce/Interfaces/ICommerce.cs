using WPA.CommerceApp.Helpers;

namespace WPA.CommerceApp.Interfaces
{
    public interface ICommerce
    {
        void ProcessOrder(OrderInfo orderInfo);
    }
}