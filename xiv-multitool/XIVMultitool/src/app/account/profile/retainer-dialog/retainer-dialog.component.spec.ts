import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RetainerDialogComponent } from './retainer-dialog.component';

describe('RetainerDialogComponent', () => {
  let component: RetainerDialogComponent;
  let fixture: ComponentFixture<RetainerDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RetainerDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RetainerDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
