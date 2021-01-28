using FactoryPaternBestPractices.Models;

namespace FactoryPaternBestPractices.Interfaces
{
    public interface IOrder
    {
        int Amount { get; set; }
        string Article { get; set; }
        ICustomer Customer { get; set; }
        decimal Price { get; set; }

        void OrderConfirmation();
    }
}