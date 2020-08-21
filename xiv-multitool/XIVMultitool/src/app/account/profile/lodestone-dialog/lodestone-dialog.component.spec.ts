import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LodestoneDialogComponent } from './lodestone-dialog.component';

describe('LodestoneDialogComponent', () => {
  let component: LodestoneDialogComponent;
  let fixture: ComponentFixture<LodestoneDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LodestoneDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LodestoneDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
