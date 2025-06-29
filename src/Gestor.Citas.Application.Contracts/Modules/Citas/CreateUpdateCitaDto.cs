using System;
using System.ComponentModel.DataAnnotations;
using Gestor.Citas.Modules.Cita;
using Gestor.Citas.Modules.Profesionales;
using Volo.Abp.Application.Dtos;

namespace Gestor.Citas.Modules.CitasDto;

public class CreateUpdateCitaDto
{
    [Required]
    public Guid ClienteId { get; set; }

    [Required]
    public Guid ProfesionalId { get; set; }
    
    [Required]
    public DateTime FechaCita { get; set; }

    [Required]
    [StringLength(500)]
    public string Motivo { get; set; }
    
    public CitaEstado Estado { get; set; } = CitaEstado.Pendiente;
    public string? Ubicacion { get; set; }
    public ModalidadCita Modalidad { get; set; } = ModalidadCita.Presencial;
    public string? NotasInternas { get; set; }
    public string? ObservacionesCliente { get; set; }
    
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }
}