import { RoutesService, eLayoutType } from '@abp/ng.core';
import { inject, provideAppInitializer } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  provideAppInitializer(() => {
    configureRoutes();
  }),
];

function configureRoutes() {
  const routes = inject(RoutesService);
  routes.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      
      {
        path: '/clientes',
        name: '::Menu:Clients',
        iconClass: 'fas fa-user',
        layout: eLayoutType.application,
        requiredPolicy: 'Citas.Clientes',
      },
      {
        path: '/profesionales',
        name: '::Menu:Professionals',
        iconClass: 'fas fa-user-tie',
        layout: eLayoutType.application,
        requiredPolicy: 'Citas.Profesionales',
      },
      {
        path: '/citas',
        name: '::Menu:Appointments',
        iconClass: 'fas fa-book',
        layout: eLayoutType.application,
        requiredPolicy: 'Citas.Citas',
      },
  ]);
}
