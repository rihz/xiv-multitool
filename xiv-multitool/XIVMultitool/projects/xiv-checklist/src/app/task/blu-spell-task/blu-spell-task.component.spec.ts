import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BluSpellTaskComponent } from './blu-spell-task.component';

describe('BluSpellTaskComponent', () => {
  let component: BluSpellTaskComponent;
  let fixture: ComponentFixture<BluSpellTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BluSpellTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BluSpellTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
