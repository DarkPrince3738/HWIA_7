using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public int Index;
        public string Country;
        public string City;
        public string Street;
        public string House;
        public string Apartment;

        public Address(
            int index,
            string country,
            string city,
            string street,
            string house,
            string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
    }
}
