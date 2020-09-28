namespace Isnet.ResourceManagement
{
    public static class ResourceManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = "ResourceManagement";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "ResourceManagement";
    }
}
