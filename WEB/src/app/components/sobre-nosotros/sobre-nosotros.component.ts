import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { OpinionesService } from 'src/app/services/opiniones.service';

@Component({
  selector: 'app-sobre-nosotros',
  templateUrl: './sobre-nosotros.component.html',
  styleUrls: ['./sobre-nosotros.component.css'],
})
export class SobreNosotrosComponent implements OnInit {
  currentRate: number;

  constructor(private fb: FormBuilder, private _opiniones: OpinionesService) {
    this.currentRate = 0;
  }
  ngOnInit(): void {}

  opinionesForm = this.fb.group({
    Nombre: ['', Validators.required],
    Apellidos: ['', Validators.required],
    Email: ['', Validators.required],
    Telefono: ['', Validators.required],
    Comentario: ['', Validators.required],
  });

  onSubmit() {
    this._opiniones.postOpinionesData(
      this.opinionesForm.value,
      this.currentRate
    );
    window.location.reload();
  }
}
