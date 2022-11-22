using LoanService.Api.Calculate;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetLoanEligibleAmount_WhenTransHistoryIsNotEmpty_ReturnsSum()
        {
            //Arrange
            var history = new decimal[] { 5000.00M, 6000.00M, 9000M };
            var loanService = new Service();

            //Act
            var res = loanService.GetLoanEligibleAmount(history);

            //Assert

            Assert.Equal(20000.00M, res);
        }
    }
}