using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace before
{
    public class ChargeCalculator
    {
        private static readonly DateTime SUMMER_START = new DateTime(2025, 6, 1);
        private static readonly DateTime SUMMER_END = new DateTime(2025, 8, 31);

        private const double SUMMER_RATE = 0.5;
        private const double WINTER_RATE = 0.3;
        private const double WINTER_SERVICE_CHARGE = 10.0;

        public double GetCharge(DateTime date, double quantity)
        {
            double charge;

            // ❌ Câu điều kiện phức tạp
            if (date < SUMMER_START || date > SUMMER_END)
            {
                charge = quantity * WINTER_RATE + WINTER_SERVICE_CHARGE;
            }
            else
            {
                charge = quantity * SUMMER_RATE;
            }

            return charge;
        }
    }
}
