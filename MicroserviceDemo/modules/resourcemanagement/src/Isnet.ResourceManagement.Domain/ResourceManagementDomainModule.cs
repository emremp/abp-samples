using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Isnet.ResourceManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ResourceManagementDomainSharedModule)
    )]
    public class ResourceManagementDomainModule : AbpModule
    {

    }
}
