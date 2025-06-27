using System;
using System.Collections.Generic;
using Gestor.Citas.Modules.Horarios;
using Volo.Abp.Domain.Entities.Auditing;

namespace Gestor.Citas.Modules.Profesionales
{
    public class Profesional : FullAuditedAggregateRoot<Guid>
    {
        public string Nombre { get; set; }
        public string Especializacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        
        public virtual ICollection<HorarioLaboral> HorariosLaborales { get; set; }
        
        public Profesional()
        {
            HorariosLaborales = new HashSet<HorarioLaboral>(); 
        }


    }
}