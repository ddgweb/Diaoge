using Abp.AspNetCore.Mvc.Controllers;

namespace Diaoge.Web.Controllers
{
    public abstract class DiaogeControllerBase: AbpController
    {
        protected DiaogeControllerBase()
        {
            LocalizationSourceName = DiaogeConsts.LocalizationSourceName;
        }
    }
}