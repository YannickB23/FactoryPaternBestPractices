using FactoryPaternBestPractices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPaternBestPractices.Models
{
    public class Order : IOrder
    {
        public string Article { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public ICustomer Customer { get; set; }
        private readonly ISendMessage _sendMessage;
        private readonly ILogger _logger;
        public Order(ISendMessage sendMessage, ILogger logger)
        {
            _sendMessage = sendMessage;
            _logger = logger;
        }
        public void OrderConfirmation()
        {
            ISendMessage($"We confirm that {Article} is delivered to {Customer.FirstName} {Customer.LastName}, {Customer.Address}.\n");
            Log($"{Article} bought by {Customer.FirstName + " " + Customer.LastName} on {DateTime.Now.ToShortDateString()} and the value paid is: EUR {Price}.");
        }
        private void ISendMessage(string message)
        {
            //Email messager = new Email();
            _sendMessage.SendMessage(message);
        }
        private void Log(string message)
        {
            //Logger logger = new Logger();
            _logger.Log(message);
        }
    }
}
