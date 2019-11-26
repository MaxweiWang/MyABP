using Abp.AspNetCore.Mvc.ViewComponents;

namespace maxwell.MyABP.Web.Views
{
    public abstract class MyABPViewComponent : AbpViewComponent
    {
        protected MyABPViewComponent()
        {
            LocalizationSourceName = MyABPConsts.LocalizationSourceName;
        }
    }
}
