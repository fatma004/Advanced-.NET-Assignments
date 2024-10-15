using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_CustomerNotifications
{
    public interface INotify
    {
        void Send(string message);
    }
}
