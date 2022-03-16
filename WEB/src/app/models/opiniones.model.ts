export class Opiniones {
  id: number;

  nombre: string | null;

  apellidos: string | null;

  email: string | null;

  telefono: number;

  calificacion: number;

  comentario: string | null;

  constructor() {
    this.id = 0;
    this.nombre = null;
    this.apellidos = null;
    this.email = null;
    this.telefono = 0;
    this.calificacion = 0;
    this.comentario = null;

  }
}

