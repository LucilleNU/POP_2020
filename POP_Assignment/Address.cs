using System;
using System.Collections.Generic;
using System.Text;
namespace POP_Assignment
{
    class Address
    {
        public string address;
        public string Street;
        public string City;
        public string Country;
        public string Full_Address;

        public Address(string Address, string street, string city, string country)
        {
            address = Address;
            Street = street;
            City = city;
            Country = country;

            Full_Address = Address + " , " + street + " , " + city + " , " + country;
        }
    }
}
