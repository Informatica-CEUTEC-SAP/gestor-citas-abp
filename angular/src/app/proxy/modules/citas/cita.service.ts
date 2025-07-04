import { RestService, Rest } from '@abp/ng.core';
import type { PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CitaDto, CreateUpdateCitaDto } from '../citas-dto/models';
import type { PagedAndSortedIncludeSearchInputDto } from '../common/models';

@Injectable({
  providedIn: 'root',
})
export class CitaService {
  apiName = 'Default';
  

  create = (input: CreateUpdateCitaDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CitaDto>({
      method: 'POST',
      url: '/api/app/cita',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/cita/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CitaDto>({
      method: 'GET',
      url: `/api/app/cita/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedIncludeSearchInputDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<CitaDto>>({
      method: 'GET',
      url: '/api/app/cita',
      params: { generalSearch: input.generalSearch, includes: input.includes, sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdateCitaDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CitaDto>({
      method: 'PUT',
      url: `/api/app/cita/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
