using BackendTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest1.Services
{
    public class SushiCatalogService : ISushiCatalogService
    {
        private readonly List<SushiItem> sushiItems = new List<SushiItem>();

        public SushiCatalogService()
        {
            AddSushi(new SushiItem() { Name = "Alaska roll", Remains = 2 });
            AddSushi(new SushiItem() { Name = "California roll", Remains = 2 });
            AddSushi(new SushiItem() { Name = "Norway roll", Remains = 2 });
            AddSushi(new SushiItem() { Name = "Philadelphia roll", Remains = 2 });
            AddSushi(new SushiItem() { Name = "Seattle roll", Remains = 2 });
        }

        public IReadOnlyList<SushiItem> GetItems()
        {
            return sushiItems;
        }

        public Boolean PurchaseItems(List<String> names)
        {
            return true;
        }

        private void AddSushi(SushiItem sushi)
        {
            sushiItems.Add(sushi);
        }
    }
}
