export class Provee {
  id: number;

  idProducto: number;

  idProveedor: number;

  precio: number;

  nombreProducto: string | null;

  img: string | null;

  nombreProveedor: string | null;

  poblacion: string | null;

  telefono: string | null;

  constructor() {
    this.id = 0;
    this.idProducto = 0;
    this.idProveedor = 0;
    this.precio = 0;
    this.nombreProducto = null;
    this.img = null;
    this.nombreProveedor = null;
    this.poblacion = null;
    this.telefono = null;
  }
}
