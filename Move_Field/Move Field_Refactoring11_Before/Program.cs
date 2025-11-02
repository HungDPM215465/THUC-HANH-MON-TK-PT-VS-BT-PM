using System;

namespace Problem_MoveField
{
    class Program
    {
        static void Main(string[] args)
        {
            var plan = new CustomerPlan();
            var customer = new Customer("Nguyễn Văn A", plan, 0.1); // 10% discount
            Console.WriteLine("Customer: " + customer.Name);
        }
    }

    class CustomerPlan
    {
        // Lớp này nên chứa thông tin về discount rate
    }

    class Customer
    {
        public string Name { get; private set; }
        private CustomerPlan _plan;
        private double _discountRate;

        public Customer(string name, CustomerPlan plan, double discountRate)
        {
            Name = name;
            _plan = plan;
            _discountRate = discountRate;
        }
    }
}