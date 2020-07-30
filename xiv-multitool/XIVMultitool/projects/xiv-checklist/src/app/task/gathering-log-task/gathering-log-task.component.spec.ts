import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GatheringLogTaskComponent } from './gathering-log-task.component';

describe('GatheringLogTaskComponent', () => {
  let component: GatheringLogTaskComponent;
  let fixture: ComponentFixture<GatheringLogTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GatheringLogTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GatheringLogTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
