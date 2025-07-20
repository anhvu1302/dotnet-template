using AssetService.Localization;
using Volo.Abp.Application.Services;

namespace AssetService.Services;

/* Inherit your application services from this class. */
public abstract class AssetServiceAppService : ApplicationService
{
    protected AssetServiceAppService()
    {
        LocalizationResource = typeof(AssetServiceResource);
    }
}