using Acme.TrannerShop.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.TrannerShop.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TrannerShopEntityFrameworkCoreModule),
    typeof(TrannerShopApplicationContractsModule)
    )]
public class TrannerShopDbMigratorModule : AbpModule
{

}
