using Microsoft.AspNetCore.Mvc;
using BusinessEnterprise.Models;
using BusinessEnterprise.Services;

namespace BusinessEnterprise.Controllers
{
    public class TransactionController : Controller
    {
        private readonly BusinessService _businessService;

        // Dependency Injection of the BusinessService
        public TransactionController(BusinessService businessService)
        {
            _businessService = businessService;
        }

        // GET: Transaction/Index - Display all transactions
        public IActionResult Index()
        {
            var transactions = _businessService.GetTransactions();
            return View(transactions);
        }

        // GET: Transaction/Create - Display form to add a new transaction
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transaction/Create - Add new transaction to the list
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _businessService.AddTransaction(transaction);
                return RedirectToAction("Index");
            }
            return View(transaction);
        }

        // GET: Transaction/ProfitLoss - Display Profit & Loss statement
        public IActionResult ProfitLoss()
        {
            var profitLoss = _businessService.CalculateProfitLoss();
            return View(profitLoss);
        }
    }
}
