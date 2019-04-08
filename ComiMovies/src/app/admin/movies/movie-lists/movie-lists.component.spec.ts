import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { MovieListsComponent } from './movie-lists.component';

describe('CreateMoviesComponent', () => {
  let component: MovieListsComponent;
  let fixture: ComponentFixture<MovieListsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MovieListsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MovieListsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
