import type { CreateUpdateHorarioLaboralDto, HorarioLaboralDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class HorarioLaboralService {
  apiName = 'Default';
  

  create = (input: CreateUpdateHorarioLaboralDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, HorarioLaboralDto>({
      method: 'POST',
      url: '/api/app/horario-laboral',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/horario-laboral/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, HorarioLaboralDto>({
      method: 'GET',
      url: `/api/app/horario-laboral/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<HorarioLaboralDto>>({
      method: 'GET',
      url: '/api/app/horario-laboral',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  getListByProfesionalId = (profesionalId: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, HorarioLaboralDto[]>({
      method: 'GET',
      url: `/api/app/horario-laboral/by-profesional-id/${profesionalId}`,
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdateHorarioLaboralDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, HorarioLaboralDto>({
      method: 'PUT',
      url: `/api/app/horario-laboral/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
