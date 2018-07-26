using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhuocProjectTest.Configuration;
using PhuocProjectTest.EntityFrameworkCore;
using PhuocProjectTest.Migrator.DependencyInjection;

namespace PhuocProjectTest.Migrator
{
    [DependsOn(typeof(PhuocProjectTestEntityFrameworkModule))]
    public class PhuocProjectTestMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PhuocProjectTestMigratorModule(PhuocProjectTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PhuocProjectTestMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PhuocProjectTestConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhuocProjectTestMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
