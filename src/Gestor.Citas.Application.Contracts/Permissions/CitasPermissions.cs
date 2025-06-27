namespace Gestor.Citas.Permissions;

public static class CitasPermissions
{
    public const string GroupName = "Citas";



    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    
    public static class Clientes
    {
        public const string Default = GroupName + ".Clientes";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static class Profesionales
    {
        public const string Default = GroupName + ".Profesionales";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    
    public static class Citas
    {
        public const string Default = GroupName + ".Citas";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    public static class HorariosLaborales
    {
        public const string Default = GroupName + ".HorariosLaborales";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
