using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;//تزریق وابستگی
        private int pageSize = 4;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index(string Category="",int pageNumber=1)
        {
            var viewmodel = new ProductListViewModel
            {
                Data = productRepository.GetAll(pageNumber, pageSize, Category),
                CurrentCategory = Category
            };
            return View(viewmodel );
        }
    }
}
 