using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.TrannerShop;

[Dependency(ReplaceServices = true)]
public class TrannerShopBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TrannerShop";
}
