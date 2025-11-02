using System;

namespace RemoveParameter_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GetContact(DateTime.Now);
        }
    }

    class Customer
    {
        public void GetContact(DateTime date)
        {
            // Tham số 'date' KHÔNG được dùng
            Console.WriteLine("Contact information is the same every day.");
        }
    }
}
