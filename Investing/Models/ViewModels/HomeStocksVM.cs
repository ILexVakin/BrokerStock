using System.Collections.Generic;

namespace Investing.Models.ViewModels
{
    public class HomeStocksVM
    {
        public IEnumerable<Stock> Stock { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}
