import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RetainerSelectorComponent } from './retainer-selector.component';

describe('RetainerSelectorComponent', () => {
  let component: RetainerSelectorComponent;
  let fixture: ComponentFixture<RetainerSelectorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RetainerSelectorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RetainerSelectorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
