using System;
using Volo.Abp.Application.Dtos;

namespace Gestor.Citas.Modules.Horarios;

public class HorarioLaboralDto: EntityDto<Guid>
{
    
    public Guid ProfesionalId { get; set; }
    public DayOfWeekSemana DayOfWeekSemana { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }
    public bool EstaActivo { get; set; }
    public string NombreProfesional { get; set; } 
    public string DiaDeSemana { get; set; } 
}

