using Acme.TrannerShop.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.TrannerShop;

[DependsOn(
    typeof(TrannerShopEntityFrameworkCoreTestModule)
    )]
public class TrannerShopDomainTestModule : AbpModule
{

}
