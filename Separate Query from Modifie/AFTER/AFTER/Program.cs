using System;

namespace SeparateQueryModifier_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            // Tách riêng hành vi
            double total = customer.GetTotalOutstanding(); // chỉ lấy dữ liệu
            customer.SetReadyForSummaries();               // thay đổi trạng thái

            Console.WriteLine($"Total outstanding: {total}");
        }
    }

    class Customer
    {
        private bool readyForSummaries = false;
        private double totalOutstanding = 500.0;

        // Chỉ làm nhiệm vụ truy vấn (query)
        public double GetTotalOutstanding()
        {
            return totalOutstanding;
        }

        // Chỉ làm nhiệm vụ thay đổi (modifier)
        public void SetReadyForSummaries()
        {
            readyForSummaries = true;
            Console.WriteLine("Customer is now ready for summaries.");
        }
    }
}
