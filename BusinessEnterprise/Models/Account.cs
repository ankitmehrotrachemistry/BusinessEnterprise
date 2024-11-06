namespace BusinessEnterprise.Models
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Capital { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal ProfitOrLoss { get; set; }
    }
}
