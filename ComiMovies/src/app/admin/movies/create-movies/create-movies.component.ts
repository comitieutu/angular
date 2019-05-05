import { Component, OnInit } from '@angular/core';
import { COUNTRY } from './country.config';
import { LANGUAGES } from '../../commons/movie.config';
import { FormControl, FormGroup } from '@angular/forms';
import { Kind, QUALITY, DIRECTORS, ACTORS } from 'src/app/models/movies';
import { Director } from 'src/app/models/director';

declare var $:any;

@Component({
  selector: 'app-create-movies',
  templateUrl: './create-movies.component.html',
  styleUrls: ['./create-movies.component.css']
})
export class CreateMoviesComponent implements OnInit {
  private country = COUNTRY;
  private kinds = Kind;
  private quantities = QUALITY;
  private languages = LANGUAGES;
  private directors = DIRECTORS;
  private actors = ACTORS;
  private toppingList: string[] = ['Extra cheese', 'Mushroom', 'Onion', 'Pepperoni', 'Sausage', 'Tomato'];
  
  movie = new FormGroup({
    title : new FormControl(),
    description:  new FormControl(),
    releaseDate:  new FormControl(),
    // status:  new FormControl(),
    // episode:  new FormControl(),
    quality:  new FormControl(),
    // time:  new FormControl(),
    country:  new FormControl(),
    language:  new FormControl(),
    kind:  new FormControl(),
    genreMovies:  new FormControl(),
    moviesDirectors: new FormControl(),
    moviesActors: new FormControl(),
    comments:  new FormControl(),
  });

  constructor() {
   }

  ngOnInit() {
    $.getScript('../../../../assets/js/jasny-bootstrap.min.js');

  }

}
