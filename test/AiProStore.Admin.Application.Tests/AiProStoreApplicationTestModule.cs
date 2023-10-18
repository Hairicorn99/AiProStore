using Volo.Abp.Modularity;

namespace AiProStore;

[DependsOn(
    typeof(AiProStoreApplicationModule),
    typeof(AiProStoreDomainTestModule)
    )]
public class AiProStoreApplicationTestModule : AbpModule
{

}
