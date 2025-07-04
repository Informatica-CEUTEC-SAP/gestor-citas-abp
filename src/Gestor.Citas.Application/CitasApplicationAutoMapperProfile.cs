using AutoMapper;
using Gestor.Citas.Modules.Cita;
using Gestor.Citas.Modules.CitasDto;
using Gestor.Citas.Modules.Clientes;
using Gestor.Citas.Modules.Horarios;
using Gestor.Citas.Modules.Profesionales;

namespace Gestor.Citas;

public class CitasApplicationAutoMapperProfile : Profile
{
    public CitasApplicationAutoMapperProfile()
    {

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Cliente, ClienteDto>();
        CreateMap<CreateUpdateClienteDto, Cliente>();
        CreateMap<Profesional, ProfesionalDto>();
        CreateMap<CreateUpdateProfesionalDto, Profesional>();
        CreateMap<Cita, CitaDto>();
        CreateMap<CreateUpdateCitaDto, Cita>();
        CreateMap<HorarioLaboral, HorarioLaboralDto>()
            .ForMember(dest => dest.DiaDeSemana, opt => opt.MapFrom(src => src.DayOfWeekSemana.ToString()));
        CreateMap<CreateUpdateHorarioLaboralDto, HorarioLaboral>();
        CreateMap<Profesional, ProfesionalDto>();
    }
}
