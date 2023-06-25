using Volo.Abp.Modularity;

namespace Acme.TrannerShop;

[DependsOn(
    typeof(TrannerShopApplicationModule),
    typeof(TrannerShopDomainTestModule)
    )]
public class TrannerShopApplicationTestModule : AbpModule
{

}
