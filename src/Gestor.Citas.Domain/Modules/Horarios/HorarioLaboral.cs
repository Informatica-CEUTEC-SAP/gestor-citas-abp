using System;
using Gestor.Citas.Modules.Profesionales;
using Volo.Abp.Domain.Entities;

namespace Gestor.Citas.Modules.Horarios;


    public class HorarioLaboral : Entity<Guid> 
    {
        public Guid ProfesionalId { get; set; }
        
        public virtual Profesional Profesional { get; set; } 
        public DayOfWeekSemana DayOfWeekSemana { get; set; } 
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public bool EstaActivo { get; set; } = true; 

        protected HorarioLaboral() {}

        public HorarioLaboral(Guid id, Guid profesionalId, DayOfWeekSemana dayOfWeekSemana, TimeSpan horaInicio, TimeSpan horaFin, bool estaActivo = true)
            : base(id)
        {
            ProfesionalId = profesionalId;
            DayOfWeekSemana = dayOfWeekSemana;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            EstaActivo = estaActivo;
        }
    }

