using BusinessEnterprise.Models;
using BusinessEnterprise.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusinessEnterprise.Controllers
{
    public class ProfitLossController : Controller
    {
        private readonly BusinessService _businessService;

        public ProfitLossController(BusinessService businessService)
        {
            _businessService = businessService;
        }

        public IActionResult Index()
        {
            var profitLoss = _businessService.CalculateProfitLoss();
            return View(profitLoss);
        }
    }
}
