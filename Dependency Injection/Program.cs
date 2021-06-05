using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Program
    {
        static void PrintProductList(List<Product> products) =>
            products.ForEach(p => Console.WriteLine($"{p.Name} -> {p.Price}$"));

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product("Cod fish", 12.5),
                new Product("Blueberries", 5.0),
                new Product("Yogurt", 2.5)
            };

            // Joe paying via Credit Card
            CreditCard joeCard = new CreditCard("1111 2222 3333 4444", 500);
            Person joe = new Person("Joe Navarro", joeCard);

            Console.WriteLine($"{joe.Name} will be paying for:");

            Console.WriteLine("-------------------------------");
            PrintProductList(products);
            Console.WriteLine("-------------------------------");

            joe.BuyProducts(products);

            Console.WriteLine();

            // Frank paying via PayPal
            PayPal frankPaypal = new PayPal("amazing.aviator@gmail.com", 200);
            Person frank = new Person("Frank Abagnale", frankPaypal);

            Console.WriteLine($"{frank.Name} will be paying for:");

            Console.WriteLine("-------------------------------");
            PrintProductList(products);
            Console.WriteLine("-------------------------------");

            frank.BuyProducts(products);

            // Don't exit at the end of this
            Console.ReadKey();
        }
    }
}
