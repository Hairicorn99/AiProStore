using AiProStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AiProStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AiProStoreController : AbpControllerBase
{
    protected AiProStoreController()
    {
        LocalizationResource = typeof(AiProStoreResource);
    }
}
