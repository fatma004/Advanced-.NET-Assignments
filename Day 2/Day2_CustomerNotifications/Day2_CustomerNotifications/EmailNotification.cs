using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_CustomerNotifications
{
    public class EmailNotification : INotify
    {
        public void Send(string message)
        {
            Console.WriteLine($"sending Email: {message}");
        }
    }
}
