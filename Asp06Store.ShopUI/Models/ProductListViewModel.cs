namespace Asp06Store.ShopUI.Models
{
    public class ProductListViewModel
    {
        public PageData<Product> Data { get; set; }
        public string CurrentCategory { get; set; }
    }
}
