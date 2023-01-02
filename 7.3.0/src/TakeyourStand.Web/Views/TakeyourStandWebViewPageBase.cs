using Abp.Web.Mvc.Views;

namespace TakeyourStand.Web.Views
{
    public abstract class TakeyourStandWebViewPageBase : TakeyourStandWebViewPageBase<dynamic>
    {

    }

    public abstract class TakeyourStandWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TakeyourStandWebViewPageBase()
        {
            LocalizationSourceName = TakeyourStandConsts.LocalizationSourceName;
        }
    }
}