using System;

namespace Solution_MoveField
{
    class Program
    {
        static void Main(string[] args)
        {
            var plan = new CustomerPlan(0.1); // 10% discount
            var customer = new Customer("Nguyễn Văn A", plan);
            Console.WriteLine("Customer: " + customer.Name);
            Console.WriteLine("Discount Rate: " + customer.GetPlan().DiscountRate);
        }
    }

    class CustomerPlan
    {
        public double DiscountRate { get; private set; }

        public CustomerPlan(double discountRate)
        {
            DiscountRate = discountRate;
        }
    }

    class Customer
    {
        public string Name { get; private set; }
        private CustomerPlan _plan;

        public Customer(string name, CustomerPlan plan)
        {
            Name = name;
            _plan = plan;
        }

        public CustomerPlan GetPlan()
        {
            return _plan;
        }
    }
}