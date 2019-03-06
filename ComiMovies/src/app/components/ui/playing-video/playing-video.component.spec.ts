import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PlayingVideoComponent } from './playing-video.component';

describe('PlayingVideoComponent', () => {
  let component: PlayingVideoComponent;
  let fixture: ComponentFixture<PlayingVideoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PlayingVideoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PlayingVideoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
