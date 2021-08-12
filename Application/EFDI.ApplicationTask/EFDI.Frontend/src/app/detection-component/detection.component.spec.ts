import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetectionComponent } from './detection.component';

describe('DetectionComponentComponent', () => {
  let component: DetectionComponent;
  let fixture: ComponentFixture<DetectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetectionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
