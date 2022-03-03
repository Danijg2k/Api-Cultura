import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BookService } from './services/book.service';
import { NgChartsModule } from 'ng2-charts';
import { FaltasService } from './services/faltas.service';
import { CabeceraComponent } from './components/cabecera/cabecera.component';
import { CuerpoComponent } from './components/cuerpo/cuerpo.component';
import { PieComponent } from './components/pie/pie.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ErrorComponent } from './components/error/error.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponentComponent,
    CabeceraComponent,
    CuerpoComponent,
    PieComponent,
    ErrorComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, ReactiveFormsModule,HttpClientModule,NgChartsModule,NgbModule],
  providers: [BookService, FaltasService],
  exports: [CabeceraComponent],
  bootstrap: [AppComponent],
})
export class AppModule {}
