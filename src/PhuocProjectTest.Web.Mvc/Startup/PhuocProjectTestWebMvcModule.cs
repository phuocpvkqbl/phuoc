using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhuocProjectTest.Configuration;

namespace PhuocProjectTest.Web.Startup
{
    [DependsOn(typeof(PhuocProjectTestWebCoreModule))]
    public class PhuocProjectTestWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhuocProjectTestWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<PhuocProjectTestNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhuocProjectTestWebMvcModule).GetAssembly());
        }
    }
}
