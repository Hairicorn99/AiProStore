using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AiProStore.Data;

/* This is used if database provider does't define
 * IAiProStoreDbSchemaMigrator implementation.
 */
public class NullAiProStoreDbSchemaMigrator : IAiProStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
