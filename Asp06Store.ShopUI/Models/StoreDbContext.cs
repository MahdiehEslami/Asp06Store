using Microsoft.EntityFrameworkCore;

namespace Asp06Store.ShopUI.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//تنظیمات دیتابیس و امکان تعریف داده اولیه
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Category = "Mobile",
                    Name = "Apple 13 Promax",
                    Description = "Fast charging (27W, unofficial rating), 50% in 30 min (advertised)USB Power Delivery 2.0MagSafe wireless charging 15WQi magnetic fast wireless charging 7.5W",
                    Price = 49000000
                },
                 new Product
                 {
                     Id = 2,
                     Category = "Mobile",
                     Name = "Samsung Galaxy S22 Ultra 5G",
                     Description = "Armour aluminum frame with tougher drop and scratch resistance (advertised) Glass front (Gorilla Glass Victus+), glass back (Gorilla Glass Victus+),Samsung DeX, Samsung Wireless DeX (desktop experience support) aluminum   ",
                     Price = 30000000
                 },
                  new Product
                  {
                      Id = 3,
                      Category = "Mobile",
                      Name = "Xiaomi Redmi Note 11 Pro",
                      Description = "Wi-Fi 802, dual-band, Wi-Fi Direct, hotspot, Super AMOLED, 120Hz, HDR10, 700 nits (HBM), 1200 nits (peak)",
                      Price = 22000000
                  },
                   new Product
                   {
                       Id = 4,
                       Category = "Mobile",
                       Name = "BlackBerry Porsche Design P'9983",
                       Description = "BlackBerry OS 10.3, upgradable to 10.3.1 Qualcomm MSM8960T Snapdragon S4 Pro",
                       Price = 17000000
                   },
                    new Product
                    {
                        Id = 5,
                        Category = "LapTop",
                        Name = "Surface Pro X",
                        Description = "Meet the totally mobile Pro. Always with you, instantly ready, and designed to light up the best of Windows 11 Keep up anywhere, at any angle, with a detachable Keyboard* with built-in Slim Pen storage and charging^—plus ",
                        Price = 75000000
                    },
                     new Product
                     {
                         Id = 6,
                         Category = "LapTop",
                         Name = "Surface Pro 8",
                         Description = "Unlock more possibilities than ever with the Pro designed for a Pro like you. The first Surface Pro built on the Intel® Evo™ platform on select configurations†† and designed to light up the best of Windows 11, Surface Pro 8 combines the power ",
                         Price = 65000000
                     },
                      new Product
                      {
                          Id = 7,
                          Category = "LapTop",
                          Name = "Surface Pro 7",
                          Description = "Our classic Surface Pro 2-in-1 design meets high-speed performance to give you premium laptop versatility, a powerful tablet, or portable digital canvas de",
                          Price = 42000000
                      },
                      new Product
                      {
                          Id = 8,
                          Category = "LapTop",
                          Name = "Surface Go 3",
                          Description = "Microsoft Store offers 60day returns on Surface products plus free expert help, digital workshops, and remote learning opportunities. Our online associates will provide free personal assistance to help you get the right Surface for your needs.",
                          Price = 28000000
                      },
                      new Product
                      {
                          Id = 9,
                          Category = "LapTop",
                          Name = "Zenbook ",
                          Description = "Zenbook is premium, thin and light, and is the best laptop with top performance and the latest technology to unleash your creative power. ",
                          Price = 37000000
                      },
                      new Product
                      {
                          Id = 10,
                          Category = "LapTop",
                          Name = "Vivobook",
                          Description = "The bold and youthful Vivobook series represents who you are. With topnotch performance, gorgeous displays, and efficient cooling, get the job done with ease. ",
                          Price = 41000000
                      }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
