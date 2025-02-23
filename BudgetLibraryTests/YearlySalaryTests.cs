using BudgetLibrary;

namespace BudgetLibraryTests
{
    public class YearlySalaryTests
    {
        [Theory]
        [InlineData(-1000)]
        [InlineData(-100000)]
        public void SalaryCantBeNegative(decimal salary)
        {
            Assert.Throws<ArgumentException>(() => { YearlySalary s = new YearlySalary(salary); });
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(70000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        public void CanSetSalary(decimal salary)
        {
            YearlySalary s = new YearlySalary(salary);
            Assert.Equal(salary, s.Salary);
        }

        [Theory]
        [InlineData(1000001)]
        [InlineData(100000000000)]
        public void MaxSalaryIsOneMillion(decimal salary)
        {
            Assert.Throws<ArgumentException>(() => { YearlySalary s = new YearlySalary(salary); });
        }

        [Theory]
        [InlineData(80000, 3333.33)]
        [InlineData(100000, 4166.67)]
        [InlineData(1000000, 41666.67)]
        public void GetSemimonthlyPay(decimal salary, decimal expected)
        {
            YearlySalary s = new YearlySalary(salary);
            Assert.Equal(expected, s.GetPayment(PaymentPeriod.Semimonthly), 2);
        }

        [Theory]
        [InlineData(80000, 6666.67)]
        [InlineData(100000, 8333.33)]
        [InlineData(1000000, 83333.33)]
        public void GetMonthlyPay(decimal salary, decimal expected)
        {
            YearlySalary s = new YearlySalary(salary);
            Assert.Equal(expected, s.GetPayment(PaymentPeriod.Monthly), 2);
        }


        [Theory]
        [InlineData(80000, 1538.46)]
        [InlineData(100000, 1923.08)]
        [InlineData(1000000, 19230.77)]
        public void GetWeeklypay(decimal salary, decimal expected)
        {
            YearlySalary s = new YearlySalary(salary);
            Assert.Equal(expected, s.GetPayment(PaymentPeriod.Weekly), 2);
        }

        [Theory]
        [InlineData(80000, 3076.92)]
        [InlineData(100000, 3846.15)]
        [InlineData(1000000, 38461.54)]
        public void GetBiWeeklyPay(decimal salary, decimal expected) 
        {
            YearlySalary s = new YearlySalary(salary);
            Assert.Equal(expected, s.GetPayment(PaymentPeriod.Biweekly), 2);
        }


    }
}
