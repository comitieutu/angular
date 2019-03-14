import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { MoviesListComponent } from './components/movies/movies-list/movies-list.component';
import { LoginComponent } from './components/users/login/login.component';
import { RegisterComponent } from './components/users/register/register.component';
import { MovieComponent } from './components/movies/movie/movie.component';
import { PlayingVideoComponent } from './components/ui/playing-video/playing-video.component';
import { PlayMovieComponent } from './components/movies/play-movie/play-movie.component';

const routes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'login', component: LoginComponent},
  { path: 'register', component: RegisterComponent},
  { path: 'movie/:id', component: MovieComponent },
  { path: 'movies-list', component: MoviesListComponent},
  { path: 'playvideo', component: PlayingVideoComponent},
  { path: 'player', component: PlayMovieComponent},
  {
    path: 'admin',
    loadChildren: './admin/admin.module#AdminModule'
  },
  {
    path: '',
    redirectTo: '',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
