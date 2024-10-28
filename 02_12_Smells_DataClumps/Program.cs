//beispiel aufgabe zu dataclumps 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_12_Smells_DataClumps
{
    public class Customer
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Kunde: {Name}, Adresse: {Address.Street}, {Address.ZipCode} {Address.City}");
        }
    }
    public class Address
    {
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public Address(string street, string zipCode, string city)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
        }
    }
}