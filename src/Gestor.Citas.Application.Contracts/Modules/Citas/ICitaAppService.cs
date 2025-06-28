using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gestor.Citas.Modules.Clientes;
using Gestor.Citas.Modules.Common;
using Gestor.Citas.Modules.Profesionales;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Gestor.Citas.Modules.CitasDto;

public interface ICitaAppService :
    ICrudAppService<
        CitaDto,
        Guid,
        PagedAndSortedIncludeSearchInputDto,
        CreateUpdateCitaDto>
{
    
    Task<List<CitaDto>> GetCitasPorProfesionalAsync(Guid profesionalId);

    Task<Dictionary<ProfesionalDto, List<CitaDto>>> GetCitasPorTodosProfesionalesAsync();
}