import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Provee } from '../models/provee.model';

@Injectable()
export class ProveeService {
  constructor(private http: HttpClient) {}

  getProveeNoDuplicados(): Observable<Provee[]> {
    return this.http.get<Provee[]>(environment.API_URL + 'provisiones');
  }

  getProveeData(id: number): Observable<Provee[]> {
    return this.http.get<Provee[]>(
      environment.API_URL + 'provisiones/' + id + '/detail'
    );
  }
}
