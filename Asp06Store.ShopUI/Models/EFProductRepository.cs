namespace Asp06Store.ShopUI.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly StoreDbContext storeDbContext;

        public EFProductRepository( StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }
        public PageData<Product> GetAll(int pageNumber, int pageSize, string category)
        {
            var result = new PageData<Product>
            {
               pageInfo = new PageInfo
               {
                   PageSize=pageSize,
                   PageNumber=pageNumber
               }
            };
            result.Data= storeDbContext.Products.Where(c=>string.IsNullOrWhiteSpace(category) || c.Category==category).Skip((pageNumber-1)*pageSize).Take(pageSize).ToList();
            result.pageInfo.TotalCount = storeDbContext.Products.Where(c => string.IsNullOrWhiteSpace(category) || c.Category == category).Count();
            return result;
        }

        public List<string> GetAllCategories()=>

            storeDbContext.Products.Select(c => c.Category).Distinct().ToList();

        public Product GetById(int id)
        {
            return storeDbContext.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
 