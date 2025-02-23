using BudgetLibraryTests;

namespace BudgetLibrary
{
    public class HourlyWage
    {
        public decimal Wage { get; set; }

        public HourlyWage(decimal wage)
        {
            if (wage < Constants.MinimumWage)
            {
                throw new ArgumentException("Wage is below minimum wage");
            }
                Wage = wage;
        }

        public decimal GetPayment(PaymentPeriod frequency)
        {
            if (frequency == PaymentPeriod.Semimonthly)
            {
                return Wage*2000 / 24;
            }
            else if (frequency == PaymentPeriod.Biweekly)
            {
                return Wage*2000 / 26;
            }
            else if (frequency == PaymentPeriod.Weekly)
            {
                return Wage*2000 / 52;
            }
            else if (frequency == PaymentPeriod.Monthly)
            {
                return Wage*2000 / 12;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
