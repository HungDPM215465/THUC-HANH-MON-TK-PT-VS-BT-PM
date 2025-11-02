using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace after
{
    public class OrderCalculator
    {
        public void CalculateTotal(double price, bool isSpecialDeal)
        {
            double total;

            // ✅ AFTER: chỉ phần tính khác nhau trong điều kiện
            if (isSpecialDeal)
            {
                total = price * 0.95;
            }
            else
            {
                total = price * 0.98;
            }

            // ✅ Đoạn trùng được đưa ra ngoài
            Send(total);
        }

        private void Send(double total)
        {
            Console.WriteLine($"Tổng cộng: {total}");
        }
    }
}
