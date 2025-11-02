using System;

namespace RemoveParameter_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GetContact(); // Gọi hàm không cần tham số
        }
    }

    class Customer
    {
        public void GetContact()
        {
            Console.WriteLine("Contact information is the same every day.");
        }
    }
}

