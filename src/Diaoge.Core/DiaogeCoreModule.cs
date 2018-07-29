using Abp.Modules;
using Abp.Reflection.Extensions;
using Diaoge.Localization;

namespace Diaoge
{
    public class DiaogeCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            DiaogeLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DiaogeCoreModule).GetAssembly());
        }
    }
}