import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LedgerSheetComponent } from './ledger-sheet.component';

describe('LedgerSheetComponent', () => {
  let component: LedgerSheetComponent;
  let fixture: ComponentFixture<LedgerSheetComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LedgerSheetComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LedgerSheetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
