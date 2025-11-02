using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace after
{
    public class DisabilityCalculator
    {
        private int seniority;
        private int monthsDisabled;
        private bool isPartTime;

        public DisabilityCalculator(int seniority, int monthsDisabled, bool isPartTime)
        {
            this.seniority = seniority;
            this.monthsDisabled = monthsDisabled;
            this.isPartTime = isPartTime;
        }

        // ✅ AFTER: Gom điều kiện thành một biểu thức duy nhất
        public double DisabilityAmount()
        {
            if (IsNotEligibleForDisability())
                return 0;

            // đủ điều kiện
            return 1000.0;
        }

        private bool IsNotEligibleForDisability()
        {
            return (seniority < 2) || (monthsDisabled > 12) || isPartTime;
        }
    }
}
