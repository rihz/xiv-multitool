import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AchievementTaskComponent } from './achievement-task.component';

describe('AchievementTaskComponent', () => {
  let component: AchievementTaskComponent;
  let fixture: ComponentFixture<AchievementTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AchievementTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AchievementTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
