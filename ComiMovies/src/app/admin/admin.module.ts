import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SettingsService } from './services/settings.service';
import { AdminComponent } from './admin.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { FigurecardComponent } from './components/ui/figurecard/figurecard.component';
import { ImagecardComponent } from './components/ui/imagecard/imagecard.component';
import { NavbarComponent } from './components/ui/navbar/navbar.component';
import { SettingComponent } from './components/setting/setting.component';
import { CreateGenreComponent } from './genres/create-genre/create-genre.component';
import { CreateMoviesComponent } from './movies/create-movies/create-movies.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { GenreService } from '../services/genre.service';
import { ListGenreComponent } from './genres/list-genre/list-genre.component';
import { EditGenreComponent } from './genres/edit-genre/edit-genre.component';
import { MovieListsComponent } from './movies/movie-lists/movie-lists.component';
import { MaterialModule } from '../material.module';

@NgModule({
  declarations: [
    DashboardComponent,
    AdminComponent,
    SidebarComponent,
    FigurecardComponent,
    ImagecardComponent,
    NavbarComponent,
    SettingComponent,
    CreateGenreComponent,
    CreateMoviesComponent,
    ListGenreComponent,
    EditGenreComponent,
    MovieListsComponent,
    
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule
    
  ],
  providers: [
    SettingsService,
    GenreService
  ]
})
export class AdminModule { }
