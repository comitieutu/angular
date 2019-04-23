import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { FlexLayoutModule } from '@angular/flex-layout';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';

import 'hammerjs';

import { MatVideoModule } from 'mat-video';

import { PosterCardComponent } from './components/ui/poster-card/poster-card.component';

import { SwiperModule } from 'ngx-swiper-wrapper';
import { SWIPER_CONFIG } from 'ngx-swiper-wrapper';
import { SwiperConfigInterface } from 'ngx-swiper-wrapper';
import { MoviesListComponent } from './components/movies/movies-list/movies-list.component';
import { MovieComponent } from './components/movies/movie/movie.component';
import { LoginComponent } from './components/users/login/login.component';
import { RegisterComponent } from './components/users/register/register.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PlayMovieComponent } from './components/movies/play-movie/play-movie.component';
import { PlayingVideoComponent } from './components/ui/playing-video/playing-video.component';
import { AuthenticationService } from './services/authentication.service';
import { UserService } from './services/user.service';
import { HttpClientModule } from '@angular/common/http';
import { TrailerDialogComponent } from './components/ui/trailer-dialog/trailer-dialog.component';
import { MovieService } from './services/movie.service';
import { MenuComponent } from './components/ui/menu/menu.component';
import { FooterComponent } from './components/ui/footer/footer.component';
import { MaterialModule } from './material.module';
import { MatFormField, MatFormFieldControl } from '@angular/material';

const DEFAULT_SWIPER_CONFIG: SwiperConfigInterface = {
  direction: 'horizontal',
  slidesPerView: 'auto',
  keyboard: true
};

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PosterCardComponent,
    MoviesListComponent,
    MovieComponent,
    LoginComponent,
    RegisterComponent,
    PlayMovieComponent,
    PlayingVideoComponent,
    TrailerDialogComponent,
    MenuComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,   
    MatVideoModule,
    SwiperModule,
    FlexLayoutModule
  ],
  providers: [
    AuthenticationService,
    UserService,
    MovieService,
    {provide: SWIPER_CONFIG, useValue: DEFAULT_SWIPER_CONFIG}
  ],
  entryComponents: [
    TrailerDialogComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
