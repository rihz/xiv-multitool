import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ExpandedCategoryComponent } from './expanded-category.component';

describe('ExpandedCategoryComponent', () => {
  let component: ExpandedCategoryComponent;
  let fixture: ComponentFixture<ExpandedCategoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ExpandedCategoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ExpandedCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
