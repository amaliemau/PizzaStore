using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    public class Customer
    {

        private string name;
        private string phoneNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Customer(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Customer: {Name}, Phone: {PhoneNumber}";
        }
    }
}

