using System;

namespace AddParameter_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            // Có thể chỉ định ngày
            customer.GetContact(new DateTime(2025, 10, 20));
        }
    }

    class Customer
    {
        public void GetContact(DateTime date)
        {
            Console.WriteLine($"Contact information as of {date.ToShortDateString()}");
        }
    }
}

