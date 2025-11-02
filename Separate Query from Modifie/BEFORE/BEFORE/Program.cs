using System;

namespace SeparateQueryModifier_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            double total = customer.GetTotalOutstandingAndSetReadyForSummaries();
            Console.WriteLine($"Total outstanding: {total}");
        }
    }

    class Customer
    {
        private bool readyForSummaries = false;
        private double totalOutstanding = 500.0;

        // Hàm vừa trả về giá trị vừa thay đổi trạng thái (xấu)
        public double GetTotalOutstandingAndSetReadyForSummaries()
        {
            readyForSummaries = true; // Thay đổi trạng thái
            return totalOutstanding;  // Trả về giá trị
        }
    }
}
