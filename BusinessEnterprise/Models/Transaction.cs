namespace BusinessEnterprise.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool IsExpense { get; set; }  // true if it's an expense, false if income
        public string TransactionType { get; set; }  // e.g., "Purchase", "Sale"
    }
}
