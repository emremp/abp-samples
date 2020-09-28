using Localization.Resources.AbpUi;
using Isnet.ResourceManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Isnet.ResourceManagement
{
    [DependsOn(
        typeof(ResourceManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ResourceManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ResourceManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ResourceManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
