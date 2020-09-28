using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Isnet.ResourceManagement.EntityFrameworkCore
{
    public class ResourceManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ResourceManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}