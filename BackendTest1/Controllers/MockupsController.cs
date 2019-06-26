using Microsoft.AspNetCore.Mvc;

namespace BackendTest1.Controllers
{
    public class MockupsController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Sushi()
        {
            return this.View();
        }

        public IActionResult SushiSelected()
        {
            return this.View();
        }

        public IActionResult Checkout()
        {
            return this.View();
        }

        public IActionResult Receipt()
        {
            return this.View();
        }        
    }
}
