using System;

namespace IntroduceNullObject_BEFORE
{
    public class BillingPlan
    {
        public static BillingPlan Basic() => new BillingPlan("Basic Plan");
        public string Name { get; }
        public BillingPlan(string name) => Name = name;
    }

    public class Customer
    {
        public BillingPlan GetPlan() => new BillingPlan("Premium Plan");
    }

    class Program
    {
        static void Main()
        {
            Customer customer = null;
            BillingPlan plan;

            if (customer == null)
            {
                plan = BillingPlan.Basic();
            }
            else
            {
                plan = customer.GetPlan();
            }

            Console.WriteLine($"Plan: {plan.Name}");
        }
    }
}

