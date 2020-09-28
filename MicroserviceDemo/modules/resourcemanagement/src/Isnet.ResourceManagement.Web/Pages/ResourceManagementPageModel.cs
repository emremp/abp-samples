using Isnet.ResourceManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Isnet.ResourceManagement.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ResourceManagementPageModel : AbpPageModel
    {
        protected ResourceManagementPageModel()
        {
            LocalizationResourceType = typeof(ResourceManagementResource);
            ObjectMapperContext = typeof(ResourceManagementWebModule);
        }
    }
}