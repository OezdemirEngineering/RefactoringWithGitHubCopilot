
//main start herer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_14_Smells_MessagingChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Order order = new Order();
            Product product = new Product();
            Address address = new Address();
            store.Orders = [order];
            order.Product = product;
            product.Adress = address;
            address.City = "New York";


            Console.WriteLine(store.Orders[0].Product.Adress.City);
        }
    }
}

