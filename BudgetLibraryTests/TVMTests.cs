using BudgetLibrary;

namespace BudgetLibraryTests
{
    public class TVMTests
    {

        [Theory]
        [InlineData(10, 0.05, 10000, -6139.13253540759)]
        [InlineData(20, 0.1, -36000, 5351.17060886916)]
        public void CanCalulatePV(double n, decimal rate, decimal fv, decimal expected)
        {
            decimal result = TVM.PresentValue(n, rate, fv);
            Assert.Equal(result, expected, 2);
            
        }
    }
}
