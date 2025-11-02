using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace after
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
            if (IsSummer(date))
                return SummerCharge(quantity);
            else
                return WinterCharge(quantity);
        }

        private bool IsSummer(DateTime date)
        {
            return date >= SUMMER_START && date <= SUMMER_END;
        }

        private double SummerCharge(double quantity)
        {
            return quantity * SUMMER_RATE;
        }

        private double WinterCharge(double quantity)
        {
            return quantity * WINTER_RATE + WINTER_SERVICE_CHARGE;
        }
    }
}
