using AiProStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AiProStore.Admin.Permissions;

public class AiProStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AiProStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AiProStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AiProStoreResource>(name);
    }
}
