import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ConfirmDeleteLogComponent } from './confirm-delete-log.component';

describe('ConfirmDeleteLogComponent', () => {
  let component: ConfirmDeleteLogComponent;
  let fixture: ComponentFixture<ConfirmDeleteLogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ConfirmDeleteLogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ConfirmDeleteLogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
