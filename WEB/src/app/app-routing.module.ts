import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ErrorComponent } from './components/error/error.component';
import { AboutUsComponent } from './pages/about-us/about-us.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { ProductComponent } from './pages/product/product.component';
import { SeasonComponent } from './pages/season/season.component';
import { SeasonsComponent } from './pages/seasons/seasons.component';
import { ShopComponent } from './pages/shop/shop.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponentComponent,
  },
  {
    path: 'tienda',
    component: ShopComponent,
  },
  {
    path: 'productos/:idProducto',
    component: ProductComponent,
  },
  {
    path: 'temporadas',
    component: SeasonsComponent,
  },
  {
    path: 'temporadas/:idTemporada',
    component: SeasonComponent,
  },
  {
    path: 'sobre-nosotros',
    component: AboutUsComponent,
  },
  {
    path: '**',
    component: ErrorComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
