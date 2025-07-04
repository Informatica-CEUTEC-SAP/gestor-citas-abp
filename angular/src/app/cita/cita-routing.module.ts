import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CitaComponent } from './cita.component';
import { authGuard, permissionGuard } from '@abp/ng.core';

const routes: Routes = [{ path: '', component: CitaComponent, canActivate: 
  [authGuard, permissionGuard]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CitaRoutingModule { }
