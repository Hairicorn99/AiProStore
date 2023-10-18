using AiProStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AiProStore;

[DependsOn(
    typeof(AiProStoreEntityFrameworkCoreTestModule)
    )]
public class AiProStoreDomainTestModule : AbpModule
{

}
