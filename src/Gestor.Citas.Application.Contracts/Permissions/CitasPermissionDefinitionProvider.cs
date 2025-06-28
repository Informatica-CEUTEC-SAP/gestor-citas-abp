using Gestor.Citas.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Gestor.Citas.Permissions;

public class CitasPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CitasPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(CitasPermissions.MyPermission1, L("Permission:MyPermission1"));

        var clientesPermission = myGroup.AddPermission(CitasPermissions.Clientes.Default, L("Permission:Clients"));
        clientesPermission.AddChild(CitasPermissions.Clientes.Create, L("Permission:Clients.Create"));
        clientesPermission.AddChild(CitasPermissions.Clientes.Edit, L("Permission:Clients.Edit"));
        clientesPermission.AddChild(CitasPermissions.Clientes.Delete, L("Permission:Clients.Delete"));

        var profesionalesPermission = myGroup.AddPermission(CitasPermissions.Profesionales.Default, L("Permission:Professionals"));
        profesionalesPermission.AddChild(CitasPermissions.Profesionales.Create, L("Permission:Professionals.Create"));
        profesionalesPermission.AddChild(CitasPermissions.Profesionales.Edit, L("Permission:Professionals.Edit"));
        profesionalesPermission.AddChild(CitasPermissions.Profesionales.Delete, L("Permission:Professionals.Delete"));

        var citasPermission = myGroup.AddPermission(CitasPermissions.Citas.Default, L("Permission:Appointments"));
        citasPermission.AddChild(CitasPermissions.Citas.Create, L("Permission:Appointments.Create"));
        citasPermission.AddChild(CitasPermissions.Citas.Edit, L("Permission:Appointments.Edit"));
        citasPermission.AddChild(CitasPermissions.Citas.Delete, L("Permission:Appointments.Delete"));
        
        myGroup.AddPermission(CitasPermissions.Agenda, L("Permission:Agenda"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CitasResource>(name);
    }
}
