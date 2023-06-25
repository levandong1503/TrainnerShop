using System.Threading.Tasks;

namespace Acme.TrannerShop.Data;

public interface ITrannerShopDbSchemaMigrator
{
    Task MigrateAsync();
}
