using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PhuocProjectTest.Controllers
{
    public abstract class PhuocProjectTestControllerBase: AbpController
    {
        protected PhuocProjectTestControllerBase()
        {
            LocalizationSourceName = PhuocProjectTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
