namespace WPA.CommerceApp.Interfaces
{
    public interface IBillingProcess
    {
        void ProcessPayment(string customer, string creditCard, double price);
    }
}