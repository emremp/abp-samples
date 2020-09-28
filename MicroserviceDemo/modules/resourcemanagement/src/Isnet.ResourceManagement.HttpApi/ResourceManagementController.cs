using Isnet.ResourceManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Isnet.ResourceManagement
{
    public abstract class ResourceManagementController : AbpController
    {
        protected ResourceManagementController()
        {
            LocalizationResource = typeof(ResourceManagementResource);
        }
    }
}
