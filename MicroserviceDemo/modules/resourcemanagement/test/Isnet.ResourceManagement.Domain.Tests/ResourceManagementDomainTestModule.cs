using Isnet.ResourceManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Isnet.ResourceManagement
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ResourceManagementEntityFrameworkCoreTestModule)
        )]
    public class ResourceManagementDomainTestModule : AbpModule
    {
        
    }
}
