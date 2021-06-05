using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    interface IPaymentMethod
    {
        double Balance { get; set; }

        void Pay(double price);
    }
}
