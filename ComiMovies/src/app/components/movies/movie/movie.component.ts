import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { Movies } from 'src/app/models/movies';
import { ActivatedRoute } from '@angular/router';
import { TrailerDialogComponent } from '../../ui/trailer-dialog/trailer-dialog.component';
import { MatDialog } from '@angular/material';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {

  @ViewChild('closeModal') public  closeModal: ElementRef;
  @ViewChild('openModal') public  openModal: ElementRef;

  movie : Movies;

  constructor(
    private route: ActivatedRoute,
    public dialog: MatDialog,
  ) { }

  ngOnInit() {
    this.route.params.subscribe(
      params => {
        const id = params['id'];
      }
    );
    this.movie = new Movies();
    this.movie.title = "Comi";
    this.movie.name = "Le Comi";
  }

  openDialog(): void {
    this.dialog.open(TrailerDialogComponent, {
      height: '500px',
      width: '800px',
      data: { }
    });
  }
}
