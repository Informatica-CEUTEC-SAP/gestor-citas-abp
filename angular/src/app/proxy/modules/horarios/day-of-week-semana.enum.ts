import { mapEnumToOptions } from '@abp/ng.core';

export enum DayOfWeekSemana {
  Domingo = 0,
  Lunes = 1,
  Martes = 2,
  Miercoles = 3,
  Jueves = 4,
  Viernes = 5,
  Sabado = 6,
}

export const dayOfWeekSemanaOptions = mapEnumToOptions(DayOfWeekSemana);
