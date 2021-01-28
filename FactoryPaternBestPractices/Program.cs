using FactoryPaternBestPractices.Interfaces;
using FactoryPaternBestPractices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPaternBestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer = Factory.GetCustomer();
            customer.FirstName = "Yannick";
            customer.LastName = "Beterams";
            customer.Address = "Ternat";
            customer.Email = "yannick@someprovider.com";
            customer.PhoneNumber = "0123/456.789";

            IOrder order = Factory.GetOrder();
            order.Article = "Table";
            order.Amount = 1;
            order.Price = 125.25M;
            order.Customer = customer;
            order.OrderConfirmation();

            Console.ReadLine();
        }
    }
}
