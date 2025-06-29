using System;
using System.ComponentModel.DataAnnotations;

namespace Gestor.Citas.Modules.Horarios;

public class CreateUpdateHorarioLaboralDto
{
    [Required]
    public Guid ProfesionalId { get; set; }

    [Required]
    public DayOfWeekSemana DayOfWeekSemana { get; set; }

    [Required]
    public TimeSpan HoraInicio { get; set; }

    [Required]
    public TimeSpan HoraFin { get; set; }

    public bool EstaActivo { get; set; } = true;

    public bool IsHoraValida => HoraFin > HoraInicio;
}