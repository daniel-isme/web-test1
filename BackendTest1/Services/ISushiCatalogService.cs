using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendTest1.Models;

namespace BackendTest1.Services
{
    public interface ISushiCatalogService
    {
        IReadOnlyList<SushiItem> GetItems();

        Boolean PurchaseItems(List<String> names);
    }
}
