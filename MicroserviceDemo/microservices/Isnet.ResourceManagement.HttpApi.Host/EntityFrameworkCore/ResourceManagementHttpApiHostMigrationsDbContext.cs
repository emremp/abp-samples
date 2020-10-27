using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Isnet.ResourceManagement.EntityFrameworkCore
{
    public class ResourceManagementHttpApiHostMigrationsDbContext : AbpDbContext<ResourceManagementHttpApiHostMigrationsDbContext>
    {
        public ResourceManagementHttpApiHostMigrationsDbContext(DbContextOptions<ResourceManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureResourceManagement();
        }
    }
}
