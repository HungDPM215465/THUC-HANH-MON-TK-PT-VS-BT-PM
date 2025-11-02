using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace before
{
    public class DisabilityCalculator
    {
        private int seniority;       // số năm làm việc
        private int monthsDisabled;  // số tháng bị mất khả năng lao động
        private bool isPartTime;     // có phải nhân viên part-time không

        public DisabilityCalculator(int seniority, int monthsDisabled, bool isPartTime)
        {
            this.seniority = seniority;
            this.monthsDisabled = monthsDisabled;
            this.isPartTime = isPartTime;
        }

        // ❌ BEFORE: nhiều điều kiện tách rời nhưng cùng kết quả return 0
        public double DisabilityAmount()
        {
            if (seniority < 2)
                return 0;

            if (monthsDisabled > 12)
                return 0;

            if (isPartTime)
                return 0;

            // ✅ Nếu đủ điều kiện
            return 1000.0; // tính trợ cấp
        }
    }
}
