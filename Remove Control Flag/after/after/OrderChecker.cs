using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace after
{
    public class OrderChecker
    {
        public void CheckOrders(List<int> orders)
        {
            foreach (var order in orders)
            {
                if (order == 0)
                {
                    Console.WriteLine("Có đơn hàng bị lỗi (giá trị = 0).");
                    return; // ✅ dùng return thay vì flag
                }
            }

            Console.WriteLine("Tất cả đơn hàng hợp lệ.");
        }
    }
}
