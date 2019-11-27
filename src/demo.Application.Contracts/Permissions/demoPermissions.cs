namespace demo.Permissions
{
    public static class demoPermissions
    {
        public const string GroupName = "demo";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public const string DemoValidPermission = GroupName + "." + nameof(DemoValidPermission);
    }
}