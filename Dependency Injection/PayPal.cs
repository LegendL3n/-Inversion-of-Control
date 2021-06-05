using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class PayPal : IPaymentMethod
    {
        public string Email { get; set; }
        public double Balance { get; set; }

        public PayPal(string email, double balance)
        {
            Email = email;
            Balance = balance;
        }

        public void Pay(double price)
        {
            Balance -= price;
            Console.WriteLine($"Payed {price}$ via PayPal account {Email}");
        }
    }
}
