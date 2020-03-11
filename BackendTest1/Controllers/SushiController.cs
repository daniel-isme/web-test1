using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackendTest1.Services;
using BackendTest1.Models;

namespace BackendTest1.Controllers
{
    public class SushiController : Controller
    {
        private readonly ISushiCatalogService sushiCatalogService;

        public SushiController(ISushiCatalogService sushiCatalogService)
        {
            this.sushiCatalogService = sushiCatalogService;
        }

        public IActionResult Index()
        {
            var model = new SushiViewModel();
            model.sushiItems = (List<SushiItem>)sushiCatalogService.GetItems();
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(String action, SushiViewModel model)
        {
            List<String> names = new List<String>();
            names.Add(action);

            return this.View("SushiSelected", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SushiSelected(String action, SushiViewModel model)
        {
            if (action == "Checkout")
            {
                return this.View("Checkout", model);
            }
            return this.View(model);
        }
    }
}