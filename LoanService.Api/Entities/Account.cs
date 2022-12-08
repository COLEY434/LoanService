using LoanService.Api.Enums;

namespace LoanService.Api.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public decimal AvailableBalance { get; set; }
    }
}
