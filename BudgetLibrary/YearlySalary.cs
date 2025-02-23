using BudgetLibraryTests;

namespace BudgetLibrary
{
    public class YearlySalary
    {
        /// <summary>
        /// The Yearly Salary Amount
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// Creates a yearly salary
        /// </summary>
        /// <param name="salary">the yearly payment amount</param>
        public YearlySalary(decimal salary) {
            if (salary < 0 || salary > 1000000)
            {
                throw new ArgumentException("Salary Can't be negative");
            }
            Salary = salary;
        }

        public decimal GetPayment(PaymentPeriod frequency)
        {
            if (frequency == PaymentPeriod.Semimonthly)
            {
                return Salary / 24;
            }
            else if (frequency == PaymentPeriod.Biweekly)
            {
                return Salary / 26;
            }
            else if (frequency == PaymentPeriod.Weekly)
            {
                return Salary / 52;
            }
            else if (frequency == PaymentPeriod.Monthly)
            {
                return Salary / 12;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
