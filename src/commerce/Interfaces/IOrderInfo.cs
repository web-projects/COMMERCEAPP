namespace WPA.CommerceApp.Helpers
{
    public interface IOrderInfo
    {
        string CreditCard { get; set; }
        string CustomerName { get; set; }
        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
        double Price { get; set; }
        string Product { get; set; }
    }
}