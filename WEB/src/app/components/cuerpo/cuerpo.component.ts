import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  encapsulation: ViewEncapsulation.None,
  selector: 'app-cuerpo',
  templateUrl: './cuerpo.component.html',
  styleUrls: ['./cuerpo.component.css']
})
export class CuerpoComponent implements OnInit {

  imagenes:Array<String>;

  constructor() {
    this.imagenes = ['carousel1', 'carousel2'].map((n) => `/assets/img/${n}.jpg`);
  }

  ngOnInit(): void {
  }
}
