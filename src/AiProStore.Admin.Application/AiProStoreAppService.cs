using System;
using System.Collections.Generic;
using System.Text;
using AiProStore.Localization;
using Volo.Abp.Application.Services;

namespace AiProStore.Admin;

/* Inherit your application services from this class.
 */
public abstract class AiProStoreAppService : ApplicationService
{
    protected AiProStoreAppService()
    {
        LocalizationResource = typeof(AiProStoreResource);
    }
}
