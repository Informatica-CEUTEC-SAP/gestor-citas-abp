namespace Gestor.Citas.Permissions;

public static class CitasPermissions
{
    public const string GroupName = "Citas";

    
    public const string Agenda = GroupName + ".Agenda";

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
}