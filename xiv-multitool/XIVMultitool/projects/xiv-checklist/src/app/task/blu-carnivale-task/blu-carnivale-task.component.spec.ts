import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BluCarnivaleTaskComponent } from './blu-carnivale-task.component';

describe('BluCarnivaleTaskComponent', () => {
  let component: BluCarnivaleTaskComponent;
  let fixture: ComponentFixture<BluCarnivaleTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BluCarnivaleTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BluCarnivaleTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
