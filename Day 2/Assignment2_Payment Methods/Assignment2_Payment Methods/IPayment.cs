using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Payment_Methods
{
    public interface IPayment
    {
        void Pay(double amount);
    }
}
