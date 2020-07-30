import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BluLogTaskComponent } from './blu-log-task.component';

describe('BluLogTaskComponent', () => {
  let component: BluLogTaskComponent;
  let fixture: ComponentFixture<BluLogTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BluLogTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BluLogTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
