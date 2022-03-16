import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Provee } from 'src/app/models/provee.model';
import { ProveeService } from 'src/app/services/provee.service';

@Component({
  selector: 'app-producto',
  templateUrl: './producto.component.html',
  styleUrls: ['./producto.component.css'],
})
export class ProductoComponent implements OnInit {
  idProducto: number;
  provee: Provee[] | null;
  nombreProducto: string | null;
  imgProducto: string | null;

  constructor(
    private activatedRoute: ActivatedRoute,
    private _proveeService: ProveeService
  ) {
    this.idProducto = 0;
    this.provee = null;
    this.nombreProducto = null;
    this.imgProducto = null;
  }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe((parameters: any) => {
      this.idProducto = parameters.get('idProducto');
    });

    this._proveeService
      .getProveeData(this.idProducto)
      .subscribe((x) => (this.provee = x) && this.saveData());
  }

  // Solo entra en esta función si puede hacer el get anterior (si no existe provee para esa idProducto nada)
  saveData() {
    if (this.provee != null) {
      this.nombreProducto = this.provee[0].nombreProducto;
      this.imgProducto = this.provee[0].img;
    }
  }
}
