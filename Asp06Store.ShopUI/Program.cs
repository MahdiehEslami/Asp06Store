using Asp06Store.ShopUI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//هم ویو هم کنترلر-اکستنشن متد

// معرفی دیتابیس یه دی بی کانتکست و رجیستر دی بی کانتکست در دی ای کانتینر  
var cnnString = builder.Configuration.GetConnectionString("StoreCnn");//معرفی کانکشتن استرینک تعریف شده در اپ ستینگ
builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(cnnString));//تزریق وابستگی و اد کردن اکستنشن متد مربوط به کانتکست با متغیر کانکشن استرینگ تعریف شده

builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddMemoryCache();//برای ذخیره و بازیابی جهت کشینگ
builder.Services.AddSession();//فعال کردن سرویس های سشن
var app = builder.Build();
app.UseDeveloperExceptionPage();//;کنترل خطا
app.UseStatusCodePages();//وقتی خطایی بود تو یه پیج نشون بده
app.UseStaticFiles();//پشتیبانی از فایل های استاتیک
app.UseSession();//حفظ ارتباط کلاینت و سرور
app.UseRouting();//فعال کردن مسیریابی
app.UseEndpoints(endpoints =>
  {
      endpoints.MapControllerRoute("pagination", "/{controller=Home}/{action=Index}/{category}/Page{PageNumber}");//مرتب کردن ادرس جهت پیجینگ
      endpoints.MapControllerRoute("pagination", "/{controller=Home}/{action=Index}/Page{PageNumber}");
      endpoints.MapControllerRoute("pagination", "/{controller=Home}/{action=Index}/{category}");
      endpoints.MapDefaultControllerRoute();
     //اضافه کردن فرایند پراسس مسیریابی به کمک mvc   
  }
);
//"{controller=home}/{action=index}/{id?}"

app.Run();
