import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ErrorComponent } from './components/error/error.component';
import { AboutUsComponent } from './pages/about-us/about-us.component';
import { HomeComponentComponent } from './pages/home/home-component/home-component.component';
import { SeasonsComponent } from './pages/seasons/seasons.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponentComponent,
  },
  {
    path: 'sobre-nosotros',
    component: AboutUsComponent,
  },
  {
    path: 'temporadas',
    component: SeasonsComponent,
  },
  {
    path: '**',
    component: ErrorComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
