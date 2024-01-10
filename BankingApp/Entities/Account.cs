using System.Collections.Generic;

namespace BankingApp.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }    
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<TransactionHistory> TransactionHistory { get; set; }
    }
}
