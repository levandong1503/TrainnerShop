using Acme.TrannerShop.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.TrannerShop.Permissions;

public class TrannerShopPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TrannerShopPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TrannerShopPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TrannerShopResource>(name);
    }
}
