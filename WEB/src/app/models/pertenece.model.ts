export class Pertenece {
  id: number;

  idProducto: number;

  idTemporada: number;

  nombreProducto: string | null;

  imgProducto: string | null;

  nombreTemporada: string | null;

  imgTemporada: string | null;

  meses: string | null;

  constructor() {
    this.id = 0;
    this.idProducto = 0;
    this.idTemporada = 0;
    this.nombreProducto = null;
    this.imgProducto = null;
    this.nombreTemporada = null;
    this.imgTemporada = null;
    this.meses = null;
  }
}
