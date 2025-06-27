using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Gestor.Citas.Modules.Horarios;

public interface IHorarioLaboralAppService
{
    public interface IHorarioLaboralAppService :
        ICrudAppService<
            HorarioLaboralDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateHorarioLaboralDto,
            CreateUpdateHorarioLaboralDto>
    {
        Task<List<HorarioLaboralDto>> GetListByProfesionalIdAsync(Guid profesionalId);
    }
}