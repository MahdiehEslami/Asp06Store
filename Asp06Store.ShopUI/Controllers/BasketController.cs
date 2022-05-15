using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp06Store.ShopUI.Controllers
{
    public class BasketController : Controller
    {
        private readonly IProductRepository productRepository;

        public BasketController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index(string returnUrl)
        {
            BasketPageViewModel basketPageViewModel = new BasketPageViewModel
            {
                Basket = GetBasket(),
                ReturnUrl = returnUrl
            };
            return View(basketPageViewModel);
        }

        public IActionResult AddToBasket(int productId,string returnUrl)
        {
            var product=productRepository.GetById(productId);
            var basket = GetBasket();
            basket.Add(product, 1);
            SaveBasket(basket);
            return RedirectToAction("Index",new {returnUrl=returnUrl});
        }

        private void SaveBasket(Basket basket)
        {
           HttpContext.Session.SetString("Basket",JsonConvert.SerializeObject(basket));
        }

        public IActionResult RemoveFromBasket()
        {
            return RedirectToAction("Index");
        }
        private Basket GetBasket()
        {
            var basketString = HttpContext.Session.GetString("Basket");
            if (string.IsNullOrEmpty(basketString))
            {
                return new Basket();
            }
            else
            {
               return JsonConvert.DeserializeObject<Basket>(basketString);
            }
        }
    }
}
