using Abp.Application.Services;

namespace Diaoge
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class DiaogeAppServiceBase : ApplicationService
    {
        protected DiaogeAppServiceBase()
        {
            LocalizationSourceName = DiaogeConsts.LocalizationSourceName;
        }
    }
}