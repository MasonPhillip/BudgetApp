using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary
{
    public class TVM
    {
        public static decimal FutureValue(double numberOfPeriods, decimal rate, decimal presentValue)
        {
            return -presentValue*(decimal)Math.Pow((double)(1 + rate), (double)numberOfPeriods);
        }

        public static decimal PresentValue(double numberOfPeriods, decimal rate, decimal futureValue)
        {
            decimal denominator = (decimal)Math.Pow((double)(1+rate), (double)numberOfPeriods);
            return -futureValue/denominator;
        }

    }
}
