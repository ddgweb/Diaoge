using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Diaoge.Web.Startup;
namespace Diaoge.Web.Tests
{
    [DependsOn(
        typeof(DiaogeWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class DiaogeWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DiaogeWebTestModule).GetAssembly());
        }
    }
}