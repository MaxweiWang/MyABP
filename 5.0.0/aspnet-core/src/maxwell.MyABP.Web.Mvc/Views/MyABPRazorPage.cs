using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace maxwell.MyABP.Web.Views
{
    public abstract class MyABPRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyABPRazorPage()
        {
            LocalizationSourceName = MyABPConsts.LocalizationSourceName;
        }
    }
}
