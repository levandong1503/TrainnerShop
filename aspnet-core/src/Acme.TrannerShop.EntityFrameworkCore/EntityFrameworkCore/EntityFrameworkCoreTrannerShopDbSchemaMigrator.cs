using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.TrannerShop.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.TrannerShop.EntityFrameworkCore;

public class EntityFrameworkCoreTrannerShopDbSchemaMigrator
    : ITrannerShopDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTrannerShopDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TrannerShopDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TrannerShopDbContext>()
            .Database
            .MigrateAsync();
    }
}
