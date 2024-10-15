using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_CustomerNotifications
{
    public class CustomerNotification
    {
        public void SendNotification(INotify notify, string message)
        {
            notify.Send(message);
        }
    }
}
