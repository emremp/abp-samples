using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Isnet.ResourceManagement.EntityFrameworkCore
{
    [ConnectionStringName(ResourceManagementDbProperties.ConnectionStringName)]
    public interface IResourceManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}