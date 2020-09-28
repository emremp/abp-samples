using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Isnet.ResourceManagement
{
    [DependsOn(
        typeof(ResourceManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ResourceManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
