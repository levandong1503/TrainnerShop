using System;
using System.Collections.Generic;
using System.Text;
using Acme.TrannerShop.Localization;
using Volo.Abp.Application.Services;

namespace Acme.TrannerShop;

/* Inherit your application services from this class.
 */
public abstract class TrannerShopAppService : ApplicationService
{
    protected TrannerShopAppService()
    {
        LocalizationResource = typeof(TrannerShopResource);
    }
}
