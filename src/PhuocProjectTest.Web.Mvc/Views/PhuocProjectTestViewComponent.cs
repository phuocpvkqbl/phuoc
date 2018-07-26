using Abp.AspNetCore.Mvc.ViewComponents;

namespace PhuocProjectTest.Web.Views
{
    public abstract class PhuocProjectTestViewComponent : AbpViewComponent
    {
        protected PhuocProjectTestViewComponent()
        {
            LocalizationSourceName = PhuocProjectTestConsts.LocalizationSourceName;
        }
    }
}
