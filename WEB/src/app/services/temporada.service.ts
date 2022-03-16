import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Temporada } from '../models/temporada.model';

@Injectable()
export class TemporadaService {
  constructor(private http: HttpClient) {}

  getTemporadaData(): Observable<Temporada[]> {
    return this.http.get<Temporada[]>(environment.API_URL + 'temporadas');
  }
}
