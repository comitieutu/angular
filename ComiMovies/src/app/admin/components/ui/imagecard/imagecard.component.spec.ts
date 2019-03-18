import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ImagecardComponent } from './imagecard.component';

describe('ImagecardComponent', () => {
  let component: ImagecardComponent;
  let fixture: ComponentFixture<ImagecardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ImagecardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ImagecardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
