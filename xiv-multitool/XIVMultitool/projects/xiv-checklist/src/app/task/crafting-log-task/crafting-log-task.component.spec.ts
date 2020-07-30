import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CraftingLogTaskComponent } from './crafting-log-task.component';

describe('CraftingLogTaskComponent', () => {
  let component: CraftingLogTaskComponent;
  let fixture: ComponentFixture<CraftingLogTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CraftingLogTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CraftingLogTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
