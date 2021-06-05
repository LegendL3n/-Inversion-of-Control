using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class CreditCard : IPaymentMethod
    {
        public string Number { get; set; }
        public double Balance { get; set; }

        public CreditCard(string number, double balance)
        {
            Number = number;
            Balance = balance;
        }

        public void Pay(double price)
        {
            Balance -= price;
            Console.WriteLine($"Payed {price}$ via Credit Card number {Number}");
        }
    }
}
