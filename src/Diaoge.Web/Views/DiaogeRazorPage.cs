using Abp.AspNetCore.Mvc.Views;

namespace Diaoge.Web.Views
{
    public abstract class DiaogeRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected DiaogeRazorPage()
        {
            LocalizationSourceName = DiaogeConsts.LocalizationSourceName;
        }
    }
}
