namespace LoanService.Api.Controllers
{
    public class LoanService
    {
        public LoanService()
        {

        }

        public decimal GetLoanEligibleAmount(decimal[] transHistory)
        {
            decimal amount = 0;

            foreach(var trans in transHistory)
            {
                amount += trans;
            }

            return amount;
        }
    }
}
