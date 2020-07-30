import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CollectionTaskComponent } from './collection-task.component';

describe('CollectionTaskComponent', () => {
  let component: CollectionTaskComponent;
  let fixture: ComponentFixture<CollectionTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CollectionTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CollectionTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
