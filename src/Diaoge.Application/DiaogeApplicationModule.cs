using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Diaoge
{
    [DependsOn(
        typeof(DiaogeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DiaogeApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DiaogeApplicationModule).GetAssembly());
        }
    }
}