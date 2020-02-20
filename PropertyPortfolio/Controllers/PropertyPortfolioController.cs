using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyPortfolio.Models;
using System.Diagnostics;

namespace PropertyPortfolio.Controllers
{
    public class PropertyPortfolioController : Controller
    {
        public IActionResult LoadFile()
        {
            return View();
        }

        public IActionResult Properties()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
