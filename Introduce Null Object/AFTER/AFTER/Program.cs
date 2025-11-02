using System;

namespace IntroduceNullObject_AFTER
{
    public class BillingPlan
    {
        public static BillingPlan Basic() => new BillingPlan("Basic Plan");
        public string Name { get; }
        public BillingPlan(string name) => Name = name;
    }

    public abstract class Customer
    {
        public virtual bool IsNull => false;
        public abstract BillingPlan GetPlan();
    }

    public class RealCustomer : Customer
    {
        public override BillingPlan GetPlan() => new BillingPlan("Premium Plan");
    }

    // 🔸 Null Object class
    public sealed class NullCustomer : Customer
    {
        public override bool IsNull => true;
        public override BillingPlan GetPlan() => BillingPlan.Basic();
    }

    class Program
    {
        static void Main()
        {
            Customer customer = null;

            // Thay vì để null, dùng Null Object
            customer = customer ?? new NullCustomer();

            // Không cần if nữa
            BillingPlan plan = customer.GetPlan();

            Console.WriteLine($"Plan: {plan.Name}");
        }
    }
}

