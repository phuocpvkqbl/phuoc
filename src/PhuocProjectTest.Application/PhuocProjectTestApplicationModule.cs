using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhuocProjectTest.Authorization;

namespace PhuocProjectTest
{
    [DependsOn(
        typeof(PhuocProjectTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PhuocProjectTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PhuocProjectTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PhuocProjectTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
