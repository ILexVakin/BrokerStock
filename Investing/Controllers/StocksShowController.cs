using Investing.Data;
using Investing.Models;
using Investing.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Investing.Controllers
{
    public class StocksShowController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MainContext _mainContext;
        public StocksShowController(ILogger<HomeController> logger,
                              MainContext mainContext)
        {
            _logger = logger;
            _mainContext = mainContext;
        }
        public IActionResult Index()
        {
            // создаем список товаров
            HomeStocksVM homeVM = new HomeStocksVM()
            {
                Stock = _mainContext.Stock.Include(c => c.CategoryId)/*.Include(c => c.ApplicationTypes)*//*.Skip((page - 1) * pageSize).Take(pageSize)*/,
                Category = _mainContext.Category
            };

            return View(homeVM);
        }

        public IActionResult SortStocks(SortingActive sortActive = SortingActive.Default)
        {
            HomeStocksVM homeVM = new HomeStocksVM()
            {
                Stock = _mainContext.Stock.Include(c => c.CategoryId)/*.Skip((page - 1) * pageSize).Take(pageSize)*/,
                Category = _mainContext.Category
            };

            ViewData["NameSort"] = sortActive == SortingActive.NameAsc ? SortingActive.NameDesc : SortingActive.NameAsc;
            ViewData["PriceSort"] = sortActive == SortingActive.PriceAsc ? SortingActive.PriceDesc : SortingActive.PriceAsc;

            homeVM.Stock = sortActive switch
            {
                SortingActive.NameAsc => homeVM.Stock.OrderBy(c => c.Name),
                SortingActive.NameDesc => homeVM.Stock.OrderByDescending(c => c.Name),
                SortingActive.PriceAsc => homeVM.Stock.OrderBy(c => c.Price),
                SortingActive.PriceDesc => homeVM.Stock.OrderByDescending(c => c.Price),
            };
            return View(homeVM);
        }
    }
}
