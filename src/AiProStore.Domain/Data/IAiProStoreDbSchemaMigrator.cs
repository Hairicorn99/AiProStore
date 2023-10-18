using System.Threading.Tasks;

namespace AiProStore.Data;

public interface IAiProStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
