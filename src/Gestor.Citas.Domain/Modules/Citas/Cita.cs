using System;
using Gestor.Citas.Modules.Clientes;
using Gestor.Citas.Modules.Profesionales;
using Volo.Abp.Domain.Entities.Auditing;

namespace Gestor.Citas.Modules.Cita;

public class Cita : FullAuditedAggregateRoot<Guid>
{
    public DateTime FechaCita { get; set; }
    public string Motivo { get; set; }
    
    public Guid ClienteId { get; set; }
    public Guid ProfesionalId { get; set; }
    public virtual Profesional Profesional { get; set; }
    public virtual Cliente Cliente { get; set; }
    
    public CitaEstado Estado { get; set; } = CitaEstado.Pendiente;
    public string? Ubicacion { get; set; }
    public ModalidadCita Modalidad { get; set; } = ModalidadCita.Presencial;
    public string? NotasInternas { get; set; }
    public string? ObservacionesCliente { get; set; }
    
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }
}