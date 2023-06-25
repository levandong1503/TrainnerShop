using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.TrannerShop.Data;

/* This is used if database provider does't define
 * ITrannerShopDbSchemaMigrator implementation.
 */
public class NullTrannerShopDbSchemaMigrator : ITrannerShopDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
