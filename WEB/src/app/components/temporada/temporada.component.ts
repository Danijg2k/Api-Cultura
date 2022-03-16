import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Pertenece } from 'src/app/models/pertenece.model';
import { PerteneceService } from 'src/app/services/pertenece.service';

@Component({
  selector: 'app-temporada',
  templateUrl: './temporada.component.html',
  styleUrls: ['./temporada.component.css'],
})
export class TemporadaComponent implements OnInit {
  idTemporada: number;
  pertenece: Pertenece[] | null;
  nombreTemporada: string | null;
  meses: string[] | null;

  constructor(
    private activatedRoute: ActivatedRoute,
    private _perteneceService: PerteneceService
  ) {
    this.idTemporada = 0;
    this.pertenece = null;
    this.nombreTemporada = null;
    this.meses = null;
  }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe((parameters: any) => {
      this.idTemporada = parameters.get('idTemporada');
    });

    this._perteneceService
      .getPerteneceData(this.idTemporada)
      .subscribe((x) => (this.pertenece = x) && this.saveData());
  }

  saveData() {
    if (this.pertenece != null) {
      this.nombreTemporada = this.pertenece[0].nombreTemporada;
      this.meses = this.pertenece[0].meses?.split('/')!;
    }
  }
}
