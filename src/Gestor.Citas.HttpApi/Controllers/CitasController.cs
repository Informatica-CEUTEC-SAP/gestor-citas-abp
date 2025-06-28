using Gestor.Citas.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Gestor.Citas.Controllers;

// Tus controladores deben heredar de esta clase base.
public abstract class CitasController : AbpControllerBase
{
    protected CitasController()
    {
        LocalizationResource = typeof(CitasResource);
    }
}