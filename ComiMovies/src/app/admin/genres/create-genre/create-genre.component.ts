import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { GenreService } from 'src/app/services/genre.service';
import { Genre } from 'src/app/models/genre';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-genre',
  templateUrl: './create-genre.component.html',
  styleUrls: ['./create-genre.component.css']
})
export class CreateGenreComponent implements OnInit {

  genreForm: FormGroup
  constructor(
    private formBuilder: FormBuilder,
    private genreService: GenreService,
    private router: Router
  ) { }

  ngOnInit() {
    this.genreForm = this.formBuilder.group({
      name: ['']
    })
  }

  create(){
    let genre: Genre = new Genre();
    genre.name = this.genreForm.value['name']
    this.genreService.create(genre)
    if (true) {
    }
  }

}
