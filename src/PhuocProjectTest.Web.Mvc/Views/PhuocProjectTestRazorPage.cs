using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace PhuocProjectTest.Web.Views
{
    public abstract class PhuocProjectTestRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PhuocProjectTestRazorPage()
        {
            LocalizationSourceName = PhuocProjectTestConsts.LocalizationSourceName;
        }
    }
}
