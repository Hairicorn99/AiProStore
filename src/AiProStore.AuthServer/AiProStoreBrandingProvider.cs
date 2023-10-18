using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AiProStore;

[Dependency(ReplaceServices = true)]
public class AiProStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AiProStore";
}
