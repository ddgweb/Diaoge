using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Diaoge.EntityFrameworkCore
{
    [DependsOn(
        typeof(DiaogeCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class DiaogeEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DiaogeEntityFrameworkCoreModule).GetAssembly());
        }
    }
}