namespace BusinessEnterprise.Models
{
    public class ProfitLoss
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal NetProfit => TotalIncome - TotalExpenses;
    }
}
