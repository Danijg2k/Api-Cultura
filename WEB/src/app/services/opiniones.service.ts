import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Opiniones } from '../models/opiniones.model';

@Injectable()
export class OpinionesService {
  constructor(private http: HttpClient) {}

  postOpinionesData(body: any, rate: number): Opiniones {
    let bodyData = new Opiniones();
    bodyData.nombre = body.Nombre;
    bodyData.apellidos = body.Apellidos;
    bodyData.email = body.Email;
    bodyData.telefono = body.Telefono;
    bodyData.calificacion = rate;
    bodyData.comentario = body.Comentario;


    let result = new Opiniones();
    this.http.post<Opiniones>(environment.API_URL + 'opiniones', bodyData)
      .subscribe(
        (response) => {
          console.log('response received')
          result = response;
        },
        (error) => {
          console.error('error caught in component')
        }
      )
    return result;
  }
}
