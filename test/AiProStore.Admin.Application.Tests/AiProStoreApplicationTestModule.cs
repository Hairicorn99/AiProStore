using Volo.Abp.Modularity;

namespace AiProStore.Admin;

[DependsOn(
    typeof(AiProStoreApplicationModule),
    typeof(AiProStoreDomainTestModule)
    )]
public class AiProStoreApplicationTestModule : AbpModule
{

}
