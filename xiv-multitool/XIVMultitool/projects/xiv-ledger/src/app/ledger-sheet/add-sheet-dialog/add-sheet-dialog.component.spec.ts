import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddSheetDialogComponent } from './add-sheet-dialog.component';

describe('AddSheetDialogComponent', () => {
  let component: AddSheetDialogComponent;
  let fixture: ComponentFixture<AddSheetDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddSheetDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddSheetDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
