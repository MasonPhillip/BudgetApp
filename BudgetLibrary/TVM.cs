using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary
{
    public class TVM
    {
        public static decimal PresentValue(double n, decimal rate, decimal fv)
        {
            decimal denominator = (decimal)Math.Pow((double)(1+rate), (double)n);
            return -fv/denominator;
        }

    }
}
