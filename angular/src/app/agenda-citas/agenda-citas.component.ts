import { Component, OnInit } from '@angular/core';
import { CitaDto } from '../proxy/modules/citas-dto/models';
import { CitaService } from '../proxy/modules/citas/cita.service';

@Component({
  selector: 'app-agenda-citas',
  templateUrl: './agenda-citas.component.html',
})
export class AgendaCitasComponent implements OnInit {
  citas: CitaDto[] = [];
  citasPorProfesional: { [key: string]: CitaDto[] } = {};
  profesionalId = ''; // Asigna aquí el id del profesional logueado cuando lo tengas
  modoAdmin = false;  // Cambia esto según el rol logueado

  constructor(private citaService: CitaService) {}

  ngOnInit() {
    if (this.modoAdmin) {
      this.citaService.getCitasPorTodosProfesionales().subscribe(data => {
        this.citasPorProfesional = data;
      });
    } else if (this.profesionalId) {
      this.citaService.getCitasPorProfesional(this.profesionalId).subscribe(data => {
        this.citas = data;
      });
    }
  }
}