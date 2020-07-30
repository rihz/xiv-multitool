import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FateTaskComponent } from './fate-task.component';

describe('FateTaskComponent', () => {
  let component: FateTaskComponent;
  let fixture: ComponentFixture<FateTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FateTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FateTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
