using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_14_Smells_MessagingChain
{

    internal class Store
    {
        public List<Order> Orders { get; set; }
    }
    internal class Order
    {
        public Product Product { get; set; }
    }

    internal class Product
    {
        public Address Adress { get; set; }
    }

    internal class Address
    {
        public string City { get; set; }
    }
}
