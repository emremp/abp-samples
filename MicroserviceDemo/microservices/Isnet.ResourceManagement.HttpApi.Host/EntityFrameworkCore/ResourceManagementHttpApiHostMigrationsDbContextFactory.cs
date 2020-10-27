using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Isnet.ResourceManagement.EntityFrameworkCore
{
    public class ResourceManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ResourceManagementHttpApiHostMigrationsDbContext>
    {
        public ResourceManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ResourceManagementHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("ResourceManagement"));

            return new ResourceManagementHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
