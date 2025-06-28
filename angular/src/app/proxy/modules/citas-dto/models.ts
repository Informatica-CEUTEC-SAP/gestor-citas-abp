import type { AuditedEntityDto } from '@abp/ng.core';
import type { ClienteDto } from '../clientes/models';
import type { ProfesionalDto } from '../profesionales/models';

export interface CitaDto extends AuditedEntityDto<string> {
  clienteId?: string;
  profesionalId?: string;
  fechaCita?: string;
  motivo?: string;
  cliente: ClienteDto;
  profesional: ProfesionalDto;
  horaInicio?: string;
  horaFin?: string;
  estado?: string; // Puede ser 'Pendiente', 'Confirmada', 'Cancelada', etc.
  ubicacion?: string; // Ubicación de la cita, si aplica
  modalidad?: number; // Modalidad de la cita (1: Presencial, 2: Virtual, etc.)
  notasInternas?: string; // Notas internas para el profesional
  observacionesCliente?: string; // Observaciones del cliente sobre la cita

}

export interface CreateUpdateCitaDto {
  clienteId: string;
  profesionalId: string;
  fechaCita: string;
  motivo: string;
  horaInicio?: string;
  horaFin?: string;
  estado?: string; // Puede ser 'Pendiente', 'Confirmada', 'Cancelada', etc.
  observaciones?: string; // Campo opcional para notas adicionales sobre la cita
  ubicacion?: string; // Ubicación de la cita, si aplica
  modalidad?: number; // Modalidad de la cita (1: Presencial, 2: Virtual, etc.)
  notasInternas?: string; // Notas internas para el profesional
  observacionesCliente?: string; // Observaciones del cliente sobre la cita
}
