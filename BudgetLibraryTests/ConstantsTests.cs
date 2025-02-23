using BudgetLibrary;

namespace BudgetLibraryTests
{
    public class ConstantsTests
    {
        [Fact]
        public void MinimumWageShouldBeFederalMinimumWage()
        {
            Assert.Equal(7.25m, Constants.MinimumWage);
        }
    }
}
