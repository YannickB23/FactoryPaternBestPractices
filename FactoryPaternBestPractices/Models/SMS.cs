﻿using FactoryPaternBestPractices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPaternBestPractices.Models
{
    public class SMS : ISendMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS confirmation: {message}");
        }
    }
}
