using Microsoft.Extensions.Localization;
using AssetService.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AssetService;

[Dependency(ReplaceServices = true)]
public class AssetServiceBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AssetServiceResource> _localizer;

    public AssetServiceBrandingProvider(IStringLocalizer<AssetServiceResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
