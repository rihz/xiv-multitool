import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FishGuideTaskComponent } from './fish-guide-task.component';

describe('FishGuideTaskComponent', () => {
  let component: FishGuideTaskComponent;
  let fixture: ComponentFixture<FishGuideTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FishGuideTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FishGuideTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
