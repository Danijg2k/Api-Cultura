import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Pertenece } from '../models/pertenece.model';

@Injectable()
export class PerteneceService {
  constructor(private http: HttpClient) {}

  getPerteneceData(id: number): Observable<Pertenece[]> {
    return this.http.get<Pertenece[]>(
      environment.API_URL + 'pertenencias/' + id + '/detail'
    );
  }
}
