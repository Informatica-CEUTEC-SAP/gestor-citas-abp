import type { DayOfWeekSemana } from './day-of-week-semana.enum';
import type { EntityDto } from '@abp/ng.core';

export interface CreateUpdateHorarioLaboralDto {
  profesionalId: string;
  dayOfWeekSemana: DayOfWeekSemana;
  horaInicio: string;
  horaFin: string;
  estaActivo: boolean;
  isHoraValida: boolean;
}

export interface HorarioLaboralDto extends EntityDto<string> {
  profesionalId?: string;
  dayOfWeekSemana?: DayOfWeekSemana;
  horaInicio?: string;
  horaFin?: string;
  estaActivo: boolean;
  nombreProfesional?: string;
  diaDeSemana?: string;
}
