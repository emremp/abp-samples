using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Isnet.ResourceManagement.EntityFrameworkCore
{
    [ConnectionStringName(ResourceManagementDbProperties.ConnectionStringName)]
    public class ResourceManagementDbContext : AbpDbContext<ResourceManagementDbContext>, IResourceManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public ResourceManagementDbContext(DbContextOptions<ResourceManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureResourceManagement();
        }
    }
}