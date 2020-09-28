using Volo.Abp.Modularity;

namespace Isnet.ResourceManagement
{
    [DependsOn(
        typeof(ResourceManagementApplicationModule),
        typeof(ResourceManagementDomainTestModule)
        )]
    public class ResourceManagementApplicationTestModule : AbpModule
    {

    }
}
