using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Asp06Store.ShopUI.Infrastructures
{
    [HtmlTargetElement("div", Attributes = "page-model")]//فرایند دیوی که این شرایطی رو داشت
    public class PagerTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory urlHelperFactory;
        public PagerTagHelper(IUrlHelperFactory helperFactory)//برای ساخت urlhelper
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]//برای جنریت کردن
        [HtmlAttributeNotBound]//نشه به عنوان یکattributeاز Htmlبهش دیتا داد
        public ViewContext viewContext { get; set; }//اطلاعات ویو جاری
        public PageInfo PageModel { get; set; }
        public string PageAction { get; set; }
        public bool PageClassEnable { get; set; } = false;//cssمیخوام یا نه
        public string PageClass { get; set; }//اگه میخوام پیجر کلاسم چیه
        public string PageClassNormal { get; set; }//در وضعیت نرمال چه پیجر کلاس هایی داشته باشه
        public string PageClassSelected { get; set; }//در وضعیت سلکتد چه پیجر کلاس هایی داشته باشه

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(viewContext);//ایجاد یک urlhelper
            TagBuilder result = new("div");//ایجاد یک تک div
            for (int i = 1; i <= PageModel.PageCount; i++)//هر پیج یک tag a
            {
                TagBuilder tag = new("a");
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { PageNumber = i });//مقدار دهی href
                if (PageClassEnable)//اگر css میخواست
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.PageNumber 
                        ? PageClassSelected : PageClassNormal);//تخصیص پیجر انتخابی به پیجرم
                }
                tag.InnerHtml.Append(i.ToString());//داخل تک aبه عنوان نوشته عدد پیج نمایش داده شود
                result.InnerHtml.AppendHtml(tag);//به تگ دیو دوم همه اضافه شود

            }
            output.Content.AppendHtml(result.InnerHtml);//همه رو به تگ  دیواول اضافه کن
        }
    }
}
