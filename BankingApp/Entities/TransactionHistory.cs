using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingApp.Entities
{
    public class TransactionHistory
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public string BeneficialAccountNumber { get; set; }
        public decimal Amount { get; set; }

    }
}
