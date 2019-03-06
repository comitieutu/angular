import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PlayMovieComponent } from './play-movie.component';

describe('PlayMovieComponent', () => {
  let component: PlayMovieComponent;
  let fixture: ComponentFixture<PlayMovieComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PlayMovieComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PlayMovieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
