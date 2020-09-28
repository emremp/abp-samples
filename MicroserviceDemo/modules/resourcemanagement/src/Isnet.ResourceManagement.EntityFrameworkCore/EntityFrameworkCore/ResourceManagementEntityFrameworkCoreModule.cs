using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Isnet.ResourceManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(ResourceManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class ResourceManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ResourceManagementDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}