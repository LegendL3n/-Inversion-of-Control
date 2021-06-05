using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Person
    {
        public string Name { get; set; }
        public IPaymentMethod PayMethod { get; set; }

        public Person(string name, IPaymentMethod payMethod)
        {
            Name = name;
            PayMethod = payMethod;
        }

        /**
         * Returns true if successful, false otherwise
         */
        public bool BuyProducts(List<Product> products)
        {
            double totalPrice = 0.0;

            products.ForEach(p => totalPrice += p.Price);

            if (PayMethod.Balance < totalPrice) return false;

            PayMethod.Pay(totalPrice);

            return true;
        }
    }
}
