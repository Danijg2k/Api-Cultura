import { Component, OnInit } from '@angular/core';
import { Provee } from 'src/app/models/provee.model';
import { ProveeService } from 'src/app/services/provee.service';

@Component({
  selector: 'app-tienda',
  templateUrl: './tienda.component.html',
  styleUrls: ['./tienda.component.css'],
})
export class TiendaComponent implements OnInit {
  provee: Provee[] | null;

  constructor(private _proveeService: ProveeService) {
    this.provee = null;
  }

  ngOnInit(): void {
    this._proveeService
      .getProveeNoDuplicados()
      .subscribe((x) => (this.provee = x));
  }
}
