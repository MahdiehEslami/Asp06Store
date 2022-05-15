using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Components
{
    public class CategorySideBoxViewComponent:ViewComponent
    {
        private readonly IProductRepository productRepository;

        public CategorySideBoxViewComponent(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IViewComponentResult Invoke()
        {
            var currentCategory=RouteData.Values["category"];//اگر وجود داشته باشه دیتا میده
            ViewBag.Category = currentCategory;//میتونی ازش استفاده کنی
            return View(productRepository.GetAllCategories());
        }
    }
}
