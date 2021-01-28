using FactoryPaternBestPractices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPaternBestPractices.Models
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Following info logged: {message}");
        }
    }
}
