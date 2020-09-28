using Isnet.ResourceManagement.Localization;
using Volo.Abp.Application.Services;

namespace Isnet.ResourceManagement
{
    public abstract class ResourceManagementAppService : ApplicationService
    {
        protected ResourceManagementAppService()
        {
            LocalizationResource = typeof(ResourceManagementResource);
            ObjectMapperContext = typeof(ResourceManagementApplicationModule);
        }
    }
}
