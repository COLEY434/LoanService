namespace LoanService.Api.Calculate
{
    public class Service
    {
        public Service()
        {

        }
        public decimal GetLoanEligibleAmount(decimal[] transHistory)
        {
            decimal amount = 0;

            foreach (var trans in transHistory)
            {
                amount += trans;
            }

            return amount;
        }
    }
}
