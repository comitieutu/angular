import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ListmoviesComponent } from './listmovies/listmovies.component';
import { DetailComponent } from './detail/detail.component'

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ListmoviesComponent,
    DetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
