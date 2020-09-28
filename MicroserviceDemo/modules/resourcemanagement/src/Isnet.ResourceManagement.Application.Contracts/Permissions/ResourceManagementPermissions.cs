using Volo.Abp.Reflection;

namespace Isnet.ResourceManagement.Permissions
{
    public class ResourceManagementPermissions
    {
        public const string GroupName = "ResourceManagement";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ResourceManagementPermissions));
        }
    }
}