import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgChartsModule } from 'ng2-charts';
import { CabeceraComponent } from './components/cabecera/cabecera.component';
import { CuerpoComponent } from './components/cuerpo/cuerpo.component';
import { PieComponent } from './components/pie/pie.component';
import { ErrorComponent } from './components/error/error.component';
import { AboutUsComponent } from './pages/about-us/about-us.component';
import { TemporadasComponent } from './components/temporadas/temporadas.component';
import { SeasonsComponent } from './pages/seasons/seasons.component';
import { ShopComponent } from './pages/shop/shop.component';
import { TiendaComponent } from './components/tienda/tienda.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TemporadaService } from './services/temporada.service';
import { ProveeService } from './services/provee.service';
import { PerteneceService } from './services/pertenece.service';
import { ProductoComponent } from './components/producto/producto.component';
import { TemporadaComponent } from './components/temporada/temporada.component';
import { ProductComponent } from './pages/product/product.component';
import { SeasonComponent } from './pages/season/season.component';
import { SobreNosotrosComponent } from './components/sobre-nosotros/sobre-nosotros.component';
import { OpinionesService } from './services/opiniones.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponentComponent,
    CabeceraComponent,
    CuerpoComponent,
    PieComponent,
    ErrorComponent,
    AboutUsComponent,
    SobreNosotrosComponent,
    TemporadasComponent,
    SeasonsComponent,
    ShopComponent,
    TiendaComponent,
    ProductoComponent,
    TemporadaComponent,
    ProductComponent,
    SeasonComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgChartsModule,
    NgbModule,
  ],
  providers: [TemporadaService, ProveeService, PerteneceService, OpinionesService],
  exports: [CabeceraComponent],
  bootstrap: [AppComponent],
})
export class AppModule {}
