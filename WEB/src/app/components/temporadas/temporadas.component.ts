import { Component, OnInit } from '@angular/core';
import { Temporada } from 'src/app/models/temporada.model';
import { TemporadaService } from 'src/app/services/temporada.service';

@Component({
  selector: 'app-temporadas',
  templateUrl: './temporadas.component.html',
  styleUrls: ['./temporadas.component.css'],
})
export class TemporadasComponent implements OnInit {
  temporadas: Temporada[] | null;

  constructor(private _temporadaService: TemporadaService) {
    this.temporadas = null;
  }

  ngOnInit(): void {
    this._temporadaService
      .getTemporadaData()
      .subscribe((x) => (this.temporadas = x));
  }
}
