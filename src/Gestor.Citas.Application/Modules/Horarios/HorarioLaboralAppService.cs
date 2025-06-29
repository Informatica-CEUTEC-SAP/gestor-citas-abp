using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Gestor.Citas.Modules.Profesionales;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Gestor.Citas.Modules.Horarios
{
public class HorarioLaboralAppService :
    CrudAppService<
        HorarioLaboral,
        HorarioLaboralDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateHorarioLaboralDto,
        CreateUpdateHorarioLaboralDto>,
    IHorarioLaboralAppService
{
private readonly IRepository<Profesional, Guid> _profesionalRepository;

        public HorarioLaboralAppService(
            IRepository<HorarioLaboral, Guid> repository,
            IRepository<Profesional, Guid> profesionalRepository)
            : base(repository)
        {
            _profesionalRepository = profesionalRepository;
        }

        public override async Task<HorarioLaboralDto> CreateAsync(CreateUpdateHorarioLaboralDto input)
        {
            if (!input.IsHoraValida)
            {
                throw new Volo.Abp.UserFriendlyException("La hora de fin debe ser posterior a la hora de inicio.");
            }

            var existingHorarios = await Repository.GetQueryableAsync();
            var overlappingHorario = existingHorarios
                .Where(hl => hl.ProfesionalId == input.ProfesionalId &&
                             hl.DayOfWeekSemana == input.DayOfWeekSemana &&
                             hl.EstaActivo && 
                             (
                                 (input.HoraInicio < hl.HoraFin && input.HoraFin > hl.HoraInicio) || 
                                 (hl.HoraInicio < input.HoraFin && hl.HoraFin > input.HoraInicio)    
                             ))
                .FirstOrDefault();

            if (overlappingHorario != null)
            {
                throw new Volo.Abp.UserFriendlyException(
                    $"Ya existe un horario que se solapa para el profesional en el día {input.DayOfWeekSemana} de {overlappingHorario.HoraInicio:hh\\:mm} a {overlappingHorario.HoraFin:hh\\:mm}.");
            }

            return await base.CreateAsync(input);
        }

        public override async Task<HorarioLaboralDto> UpdateAsync(Guid id, CreateUpdateHorarioLaboralDto input)
        {
            if (!input.IsHoraValida)
            {
                throw new Volo.Abp.UserFriendlyException("La hora de fin debe ser posterior a la hora de inicio.");
            }

            var existingHorarios = await Repository.GetQueryableAsync();
            var overlappingHorario = existingHorarios
                .Where(hl => hl.Id != id && 
                             hl.ProfesionalId == input.ProfesionalId &&
                             hl.DayOfWeekSemana == input.DayOfWeekSemana &&
                             hl.EstaActivo &&
                             (
                                 (input.HoraInicio < hl.HoraFin && input.HoraFin > hl.HoraInicio) ||
                                 (hl.HoraInicio < input.HoraFin && hl.HoraFin > input.HoraInicio)
                             ))
                .FirstOrDefault();

            if (overlappingHorario != null)
            {
                throw new Volo.Abp.UserFriendlyException(
                    $"Ya existe un horario que se solapa para el profesional en el día {input.DayOfWeekSemana} de {overlappingHorario.HoraInicio:hh\\:mm} a {overlappingHorario.HoraFin:hh\\:mm}.");
            }

            return await base.UpdateAsync(id, input);
        }

        public async Task<List<HorarioLaboralDto>> GetListByProfesionalIdAsync(Guid profesionalId)
        {
            var horarios = await Repository.GetQueryableAsync();
            var query = from horario in horarios
                        where horario.ProfesionalId == profesionalId
                        select new HorarioLaboralDto
                        {
                            Id = horario.Id,
                            ProfesionalId = horario.ProfesionalId,
                            DayOfWeekSemana = horario.DayOfWeekSemana,
                            HoraInicio = horario.HoraInicio,
                            HoraFin = horario.HoraFin,
                            EstaActivo = horario.EstaActivo,
                            DiaDeSemana = ((DayOfWeekSemana)horario.DayOfWeekSemana).ToString() 
                        };

            var result = await AsyncExecuter.ToListAsync(query);
            return result;
        }

        public override async Task<PagedResultDto<HorarioLaboralDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {

            var query = await Repository.GetQueryableAsync();

            query = query
                .OrderBy(input.Sorting ?? nameof(HorarioLaboral.DayOfWeekSemana)) 
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);

            var entities = await AsyncExecuter.ToListAsync(query);
            var totalCount = await Repository.GetCountAsync();

            return new PagedResultDto<HorarioLaboralDto>(
                totalCount,
                ObjectMapper.Map<List<HorarioLaboral>, List<HorarioLaboralDto>>(entities)
            );
        }

        
    }
}