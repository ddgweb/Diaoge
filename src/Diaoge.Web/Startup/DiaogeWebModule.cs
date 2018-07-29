using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Diaoge.Configuration;
using Diaoge.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Diaoge.Web.Startup
{
    [DependsOn(
        typeof(DiaogeApplicationModule), 
        typeof(DiaogeEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class DiaogeWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public DiaogeWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(DiaogeConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<DiaogeNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(DiaogeApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DiaogeWebModule).GetAssembly());
        }
    }
}