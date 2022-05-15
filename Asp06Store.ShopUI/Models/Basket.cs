namespace Asp06Store.ShopUI.Models
{
    public class Basket
    {
        private List<BasketItem> _items= new();
        public void Add(Product product,int quantity)
        {
            var basketItem=_items.Where(c=>c.Product==product).FirstOrDefault();
            if(basketItem!=null)
            {
                basketItem.Quantity += quantity;
            }
            else
            {
                _items.Add(new BasketItem
                {
                    Product = product,
                    Quantity = quantity
                });
            }
        }
        public void Remove(Product product)=>
            _items.RemoveAll(c=>c.Product.Id==product.Id);

        public int TotalPrice()=>
            _items.Sum(c=>c.Product.Price*c.Quantity);
        
        public void Clear()=>_items.Clear();

        public IEnumerable<BasketItem> Items => _items;
    }
    public class BasketItem
    {
        public int Id { get; set; } 
        public Product Product { get; set; }
        public int Quantity { get; set; }//tedad
    }
}
