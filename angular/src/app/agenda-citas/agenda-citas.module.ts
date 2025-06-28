import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { AgendaCitasComponent } from './agenda-citas.component';

const routes: Routes = [
  { path: '', component: AgendaCitasComponent }
];

@NgModule({
  imports: [
    CommonModule,
    AgendaCitasComponent, // Si tu componente es standalone, agrégalo aquí
    RouterModule.forChild(routes)
  ]
})
export class AgendaCitasModule {} // <-- Esta línea es CLAVE