using System;

namespace ExceptionHandlingExercises_Models.Exercise_2
{
    public class Customer
    {
        // Properties for customer details
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Municipality { get; set; }
        public string PostalCode { get; set; }

        // Constructor to initialize customer details
        public Customer(int customerNumber, string name, string address, string municipality, string postalCode)
        {
            CustomerNumber = customerNumber;
            Name = name;
            Address = address;
            Municipality = municipality;
            PostalCode = postalCode;
        }

        // Override ToString to display customer details
        public override string ToString()
        {
            return $"{Name}\n{Address}\n{Municipality} {PostalCode}";
        }

        // Override Equals to compare customers by customer number
        public override bool Equals(object obj)
        {
            if (obj is Customer customer)
            {
                return this.CustomerNumber == customer.CustomerNumber;
            }
            return false;
        }
    }
}