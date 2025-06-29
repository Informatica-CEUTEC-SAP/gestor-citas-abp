import { Component, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { HorarioLaboralService } from '../../proxy/modules/horarios/horario-laboral.service';
import { CreateUpdateHorarioLaboralDto } from '../../proxy/modules/horarios/models';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
    // eslint-disable-next-line @angular-eslint/prefer-standalone
    standalone: false,
  selector: 'app-crear-horario-modal',
  templateUrl: './crear-horario-modal.component.html',
})
export class CrearHorarioModalComponent {
  @Input() profesionalId!: string; 

  form: FormGroup;

  diasSemana = [
    { value: 0, label: 'Domingo' },
    { value: 1, label: 'Lunes' },
    { value: 2, label: 'Martes' },
    { value: 3, label: 'Miércoles' },
    { value: 4, label: 'Jueves' },
    { value: 5, label: 'Viernes' },
    { value: 6, label: 'Sábado' },
  ];

  constructor(
    public modal: NgbActiveModal,
    private fb: FormBuilder,
    private horarioService: HorarioLaboralService
  ) {
    this.form = this.fb.group({
      dayOfWeekSemana: [null, Validators.required],
      horaInicio: ['', Validators.required],
      horaFin: ['', Validators.required],
      estaActivo: [true],
    });
  }

  save() {
  if (this.form.invalid) return;

  const formValue = this.form.value;

  const horarioDto: CreateUpdateHorarioLaboralDto = {
    profesionalId: this.profesionalId,  
    dayOfWeekSemana: formValue.diaSemana,
    horaInicio: formValue.horaInicio,
    horaFin: formValue.horaFin,
    estaActivo: formValue.estaActivo,
    isHoraValida: true 
  };

  this.horarioService.create(horarioDto).subscribe({
    next: () => this.modal.close(),
    error: (err) => {
      console.error(err);
      alert("Error al guardar horario");
    }
  });
}
  close() {
    this.modal.close();
  }
}
