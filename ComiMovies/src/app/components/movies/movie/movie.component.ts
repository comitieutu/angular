import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {

  @ViewChild('closeModal') public  closeModal: ElementRef;
  @ViewChild('openModal') public  openModal: ElementRef;

  constructor() { }

  ngOnInit() {
  }

}
