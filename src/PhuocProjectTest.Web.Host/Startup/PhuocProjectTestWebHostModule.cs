using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhuocProjectTest.Configuration;

namespace PhuocProjectTest.Web.Host.Startup
{
    [DependsOn(
       typeof(PhuocProjectTestWebCoreModule))]
    public class PhuocProjectTestWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhuocProjectTestWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhuocProjectTestWebHostModule).GetAssembly());
        }
    }
}
