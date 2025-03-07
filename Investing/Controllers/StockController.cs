using Investing.Data;
using Investing.Models;
using Investing.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Investing.Controllers
{
    public class StockController : Controller
    {
        private readonly MainContext _context;
        private readonly StockMoexApi _moexService;
        public StockController(MainContext context, StockMoexApi moexService)
        {
            _context = context;
            _moexService = moexService;
        }

        [HttpGet]
        public async Task<IActionResult> GetListStocksAsync()
        {
            SearchImageService searchImage = new SearchImageService();
             await searchImage.DownloadImage("SBER");
            var stocks = await _moexService.GetStocksAsync();
            return View(stocks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStockById(long id)
        {
            var stock = await _context.Stock.FindAsync(id);

            if (stock == null)
            {
                return NotFound();
            }

            return stock;
        }
    }
}
