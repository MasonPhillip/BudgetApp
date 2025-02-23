using BudgetLibrary;

namespace BudgetLibraryTests
{
    public class HourlyWageTests
    {
        [Theory]
        [InlineData(20.00)]
        [InlineData(7.25)]
        public void CanSetWage(decimal wage)
        {
            HourlyWage w = new HourlyWage(wage);
            Assert.Equal(wage, w.Wage);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(0)]
        [InlineData(7.24)]
        public void WageCantBeBelowMinimumWage(decimal wage)
        {
            Assert.Throws<ArgumentException>(() => { new HourlyWage(wage); });
        }

        [Theory]
        [InlineData(7.25, 604.17)]
        [InlineData(20, 1666.67)]
        [InlineData(300, 25000)]
        public void CanGetSemiMonthlyWage(decimal wage, decimal expected)
        {
            HourlyWage w = new HourlyWage(wage);
            Assert.Equal(expected, w.GetPayment(PaymentPeriod.Semimonthly), 2);
        }

        [Theory]
        [InlineData(7.25, 557.692307692308)]
        [InlineData(20, 1538.46153846154)]
        [InlineData(300, 23076.9230769231)]
        public void CanGetBiWeeklyWage(decimal wage, decimal expected)
        {
            HourlyWage w = new HourlyWage(wage);
            Assert.Equal(expected, w.GetPayment(PaymentPeriod.Biweekly), 2);
        }

        [Theory]
        [InlineData(7.25, 278.846153846154)]
        [InlineData(20, 769.230769230769)]
        [InlineData(300, 11538.4615384615)]
        public void CanGetWeeklyWage(decimal wage, decimal expected)
        {
            HourlyWage w = new HourlyWage(wage);
            Assert.Equal(expected, w.GetPayment(PaymentPeriod.Weekly), 2);
        }

        [Theory]
        [InlineData(7.25, 1208.33333333333)]
        [InlineData(20, 3333.33333333333)]
        [InlineData(300, 50000)]
        public void CanGetMonthlyWage(decimal wage, decimal expected)
        {
            HourlyWage w = new HourlyWage(wage);
            Assert.Equal(expected, w.GetPayment(PaymentPeriod.Monthly), 2);
        }
    }
}
