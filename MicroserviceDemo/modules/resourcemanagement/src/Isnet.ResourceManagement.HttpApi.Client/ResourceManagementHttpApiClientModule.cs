using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Isnet.ResourceManagement
{
    [DependsOn(
        typeof(ResourceManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ResourceManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "ResourceManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ResourceManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
