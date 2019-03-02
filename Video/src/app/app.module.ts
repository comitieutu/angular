import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { MoviesDetailComponent } from './components/movies-detail/movies-detail.component';
import { MoviesListComponent } from './components/movies-list/movies-list.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MoviesDetailComponent,
    MoviesListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
