using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
    public class LayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
