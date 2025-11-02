using System;

namespace AddParameter_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GetContact(); // Không thể chỉ định ngày
        }
    }

    class Customer
    {
        public void GetContact()
        {
            Console.WriteLine("Contact information as of today.");
        }
    }
}

