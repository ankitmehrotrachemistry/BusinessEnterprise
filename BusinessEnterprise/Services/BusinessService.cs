using BusinessEnterprise.Models;
using System.Collections.Generic;
using System.Linq;

namespace BusinessEnterprise.Services
{
    public class BusinessService
    {
        private readonly List<Transaction> _transactions = new();

        // Constructor to add test data
        public BusinessService()
        {
            // Test data for debugging
            _transactions.Add(new Transaction { Id = 1, Amount = 1500, IsExpense = false, Description = "Service Revenue" });
            _transactions.Add(new Transaction { Id = 2, Amount = 200, IsExpense = false, Description = "Product Sales" });
            _transactions.Add(new Transaction { Id = 3, Amount = 300, IsExpense = true, Description = "Office Supplies" });
            _transactions.Add(new Transaction { Id = 4, Amount = 400, IsExpense = true, Description = "Utilities" });
        }

        public void AddTransaction(Transaction transaction) => _transactions.Add(transaction);

        public IEnumerable<Transaction> GetTransactions() => _transactions;

        public ProfitLoss CalculateProfitLoss()
        {
            var totalIncome = _transactions.Where(t => !t.IsExpense).Sum(t => t.Amount);
            var totalExpenses = _transactions.Where(t => t.IsExpense).Sum(t => t.Amount);

            return new ProfitLoss
            {
                TotalIncome = totalIncome,
                TotalExpenses = totalExpenses
            };
        }
    }
}
