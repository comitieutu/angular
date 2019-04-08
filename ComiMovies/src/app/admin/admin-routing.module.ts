import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AdminComponent } from './admin.component';
import { SettingComponent } from './components/setting/setting.component';
import { CreateGenreComponent } from './genres/create-genre/create-genre.component';
import { ListGenreComponent } from './genres/list-genre/list-genre.component';
import { CreateMoviesComponent } from './movies/create-movies/create-movies.component';
import { MovieListsComponent } from './movies/movie-lists/movie-lists.component';

const routes: Routes = [
  {
    path: '',
    component: AdminComponent,
    children: [
      { path: 'dashboard', component: DashboardComponent, pathMatch: 'full' },
      { path: 'settings', component: SettingComponent},
      { path: 'genres/create', component: CreateGenreComponent},
      { path: 'genres/list', component: ListGenreComponent},
      { path: 'movies/create', component: CreateMoviesComponent},
      { path: 'movies/list', component: MovieListsComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
