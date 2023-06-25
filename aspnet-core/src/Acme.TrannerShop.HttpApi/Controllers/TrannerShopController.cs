using Acme.TrannerShop.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.TrannerShop.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TrannerShopController : AbpControllerBase
{
    protected TrannerShopController()
    {
        LocalizationResource = typeof(TrannerShopResource);
    }
}
