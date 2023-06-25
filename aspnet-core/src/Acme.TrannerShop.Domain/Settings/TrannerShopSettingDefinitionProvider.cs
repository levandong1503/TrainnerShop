using Volo.Abp.Settings;

namespace Acme.TrannerShop.Settings;

public class TrannerShopSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TrannerShopSettings.MySetting1));
    }
}
